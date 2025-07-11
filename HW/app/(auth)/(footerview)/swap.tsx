import React, { useState, useCallback, useMemo } from 'react';
import {
  View,
  Text,
  TextInput,
  StyleSheet,
  TouchableOpacity,
  SafeAreaView,
  Alert,
  Keyboard,
  TouchableWithoutFeedback,
  Image,
} from 'react-native';
import { Ionicons } from '@expo/vector-icons';

type IconName = 'currency-usdt' | 'currency-btc';

interface Token {
  symbol: string;
  icon: IconName;
  color: string;
  image: any;
}

const TOKENS: Token[] = [
  {
    symbol: 'USDT',
    icon: 'currency-usdt',
    color: '#00aa90',
    image: require('../../../assets/usdt.png'),
  },
  {
    symbol: 'BNB',
    icon: 'currency-btc',
    color: '#f3ba2f',
    image: require('../../../assets/bnb.png'),
  },
];

const PERCENTAGE_OPTIONS = [
  { label: '25%', value: 0.25 },
  { label: '50%', value: 0.5 },
  { label: 'Max', value: 1 },
];

const SwapScreen = () => {
  const [fromToken, setFromToken] = useState<Token>(TOKENS[0]);
  const [toToken, setToToken] = useState<Token>(TOKENS[1]);
  const [fromAmount, setFromAmount] = useState('');
  const [toAmount, setToAmount] = useState('');

  const exchangeRate = useMemo(() => {
    const rates: { [key: string]: number } = {
      'USDT-BNB': 0.0016,
      'BNB-USDT': 625,
    };
    return rates[`${fromToken.symbol}-${toToken.symbol}`] || 1;
  }, [fromToken.symbol, toToken.symbol]);

  const handleFromAmountChange = useCallback(
    (value: string) => {
      const onlyNumbersAndDot = value.replace(/[^0-9.]/g, '');
      const cleaned = onlyNumbersAndDot
        .split('.')
        .reduce((acc, part, i) => (i === 0 ? part : acc + (i === 1 ? '.' : '') + part), '');

      setFromAmount(cleaned);

      const amount = parseFloat(cleaned);
      setToAmount(!isNaN(amount) && amount > 0 ? (amount * exchangeRate).toFixed(6) : '');
    },
    [exchangeRate]
  );

  const handlePercentagePress = useCallback(
    (percentage: number) => {
      const mockBalance = 1000;
      const amount = (mockBalance * percentage).toFixed(2);
      handleFromAmountChange(amount);
    },
    [handleFromAmountChange]
  );

  const handleSwapTokens = useCallback(() => {
    setFromToken(toToken);
    setToToken(fromToken);
    setFromAmount(toAmount);
    setToAmount(fromAmount);
  }, [fromToken, toToken, fromAmount, toAmount]);

  const validateSwap = useCallback(() => {
    const amount = parseFloat(fromAmount);
    if (!amount || amount <= 0) {
      Alert.alert('Error', 'Please enter an amount');
      return false;
    }
    if (amount < 0.001) {
      Alert.alert('Error', 'Minimum amount: 0.001');
      return false;
    }
    return true;
  }, [fromAmount]);

  const handleTrade = useCallback(() => {
    if (!validateSwap()) return;
    Alert.alert(
      'Success',
      `You have successfully swapped ${fromAmount} ${fromToken.symbol} for ${toAmount} ${toToken.symbol}`,
      [
        {
          text: 'OK',
          onPress: () => {
            setFromAmount('');
            setToAmount('');
          },
        },
      ]
    );
  }, [validateSwap, fromAmount, toAmount, fromToken.symbol, toToken.symbol]);

  const isTradeDisabled = !fromAmount || parseFloat(fromAmount) <= 0;

  return (
    <TouchableWithoutFeedback onPress={Keyboard.dismiss}>
      <SafeAreaView style={styles.container}>
        <Text style={styles.title}>Swap</Text>

        <View style={styles.card}>
          <Text style={styles.cardTitle}>Pay with</Text>
          <View style={styles.row}>
            <View style={styles.tokenSelector}>
              <Image source={fromToken.image} style={{ width: 18, height: 18, resizeMode: 'contain' }} />
              <Text style={styles.tokenText}>{fromToken.symbol}</Text>
              <Ionicons name="chevron-down" size={16} color="#999" />
            </View>
            <View style={styles.percentageButtons}>
              {PERCENTAGE_OPTIONS.map(option => (
                <TouchableOpacity
                  key={option.label}
                  style={styles.percentButton}
                  onPress={() => handlePercentagePress(option.value)}
                >
                  <Text style={styles.percentText}>{option.label}</Text>
                </TouchableOpacity>
              ))}
            </View>
          </View>
          <TextInput
            style={styles.input}
            keyboardType="numeric"
            value={fromAmount}
            onChangeText={handleFromAmountChange}
            placeholder="0.00"
            placeholderTextColor="#999"
          />
        </View>

        <TouchableOpacity style={styles.swapIconContainer} onPress={handleSwapTokens}>
          <Ionicons name="swap-vertical" size={24} color="#fff" />
        </TouchableOpacity>

        <View style={styles.card}>
          <Text style={styles.cardTitle}>You Receive</Text>
          <View style={styles.row}>
            <View style={styles.tokenSelector}>
              <Image source={toToken.image} style={{ width: 18, height: 18, resizeMode: 'contain' }} />
              <Text style={styles.tokenText}>{toToken.symbol}</Text>
              <Ionicons name="chevron-down" size={16} color="#999" />
            </View>
          </View>
          <TextInput
            style={[styles.input, styles.inputReadonly]}
            value={toAmount}
            placeholder="0.00"
            placeholderTextColor="#999"
            editable={false}
          />
        </View>

        <View style={styles.feeSection}>
          <View style={styles.feeRow}>
            <Text style={styles.feeText}>Fee</Text>
            <Text style={styles.feeValue}>2 USDT</Text>
          </View>
          <View style={styles.feeRow}>
            <Text style={styles.feeText}>Transaction type</Text>
            <Text style={styles.autoText}>Auto</Text>
          </View>
        </View>

        <TouchableOpacity
          style={[styles.tradeButton, isTradeDisabled && styles.tradeButtonDisabled]}
          onPress={handleTrade}
          disabled={isTradeDisabled}
        >
          <Ionicons name="flash-outline" size={18} color="#fff" />
          <Text style={styles.tradeText}>Trade</Text>
        </TouchableOpacity>
      </SafeAreaView>
    </TouchableWithoutFeedback>
  );
};

export default SwapScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#F8F9FB',
    padding: 20,
    paddingTop: 60,
  },
  title: {
    fontSize: 28,
    fontWeight: '700',
    alignSelf: 'center',
    marginBottom: 30,
    color: '#1A1A1A',
  },
  card: {
    backgroundColor: '#fff',
    borderRadius: 16,
    padding: 20,
    marginBottom: 16,
  },
  cardTitle: {
    fontSize: 18,
    fontWeight: '600',
    color: '#666',
    marginBottom: 18,
  },
  row: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginBottom: 12,
  },
  tokenSelector: {
    flexDirection: 'row',
    alignItems: 'center',
    backgroundColor: '#F5F5F5',
    paddingHorizontal: 14,
    paddingVertical: 10,
    borderRadius: 12,
    gap: 10,
  },
  tokenText: {
    fontSize: 18,
    fontWeight: '600',
    color: '#1A1A1A',
  },
  percentageButtons: {
    flexDirection: 'row',
    gap: 10,
  },
  percentButton: {
    backgroundColor: '#F5F5F5',
    paddingHorizontal: 16,
    paddingVertical: 8,
    borderRadius: 8,
  },
  percentText: {
    fontSize: 16,
    color: '#666',
    fontWeight: '600',
  },
  input: {
    fontSize: 36,
    fontWeight: '700',
    color: '#1A1A1A',
    paddingVertical: 10,
  },
  inputReadonly: {
    color: '#666',
  },
  swapIconContainer: {
    alignSelf: 'center',
    backgroundColor: '#0A84FF',
    padding: 14,
    borderRadius: 28,
    marginVertical: 12,
  },
  feeSection: {
    marginBottom: 24,
    paddingHorizontal: 4,
  },
  feeRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginBottom: 12,
  },
  feeText: {
    fontSize: 14,
    color: '#666',
  },
  feeValue: {
    fontSize: 14,
    fontWeight: '500',
    color: '#1A1A1A',
  },
  autoText: {
    fontSize: 14,
    fontWeight: '500',
    color: '#0A84FF',
  },
  tradeButton: {
    flexDirection: 'row',
    backgroundColor: '#0A84FF',
    borderRadius: 16,
    justifyContent: 'center',
    alignItems: 'center',
    paddingVertical: 18,
    gap: 10,
  },
  tradeButtonDisabled: {
    backgroundColor: '#CCC',
  },
  tradeText: {
    color: '#fff',
    fontSize: 20,
    fontWeight: '700',
  },
});
