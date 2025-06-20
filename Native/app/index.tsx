import React, { useState } from 'react';
import {
  Button,
  ScrollView,
  StyleSheet,
  Text,
  TextInput,
  View
} from 'react-native';

export default function App() {
  const [bill, setBill] = useState('');
  const [tipPercent, setTipPercent] = useState<number | null>(null);

  const billAmount = parseFloat(bill);
  const tip = tipPercent ? (billAmount * tipPercent) / 100 : 0;
  const total = tipPercent ? billAmount + tip : 0;

  const tipOptions = [10, 15, 20];

  return (
    <ScrollView contentContainerStyle={styles.container}>
      <Text style={styles.title}>Калькулятор чаевых</Text>

      <TextInput
        placeholder="Введите сумму счета (₼)"
        value={bill}
        onChangeText={(text) => setBill(text)}
        keyboardType="numeric"
        style={styles.input}
      />

      <Text style={{ fontSize: 18, marginVertical: 10 }}>Выберите процент чаевых:</Text>

      <View style={styles.buttonGroup}>
        {tipOptions.map((percent) => (
          <View key={percent} style={styles.buttonWrapper}>
            <Button
              title={`${percent}%`}
              onPress={() => setTipPercent(percent)}
              color={tipPercent === percent ? '#960300' : '#666'}
            />
          </View>
        ))}
      </View>

      {tipPercent !== null && !isNaN(billAmount) && billAmount > 0 && (
        <View style={{ marginTop: 20, alignItems: 'center' }}>
          <Text style={{ fontSize: 18 }}>
            Чаевые: {tip} ₼
          </Text>
          <Text style={{ fontSize: 18, marginTop: 5 }}>
            Итоговая сумма: {total} ₼
          </Text>
        </View>
      )}
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 40,
  },
  title: {
    fontSize: 24,
    marginVertical: 10,
    fontWeight: 'bold',
  },
  input: {
    borderWidth: 1,
    borderColor: '#ccc',
    padding: 10,
    width: '80%',
    borderRadius: 8,
    marginBottom: 10,
  },
  buttonGroup: {
    flexDirection: 'row',
    justifyContent: 'center',
    gap: 10,
    marginVertical: 10,
    
  },
  buttonWrapper: {
    marginHorizontal: 5,
    width: 80,
   
  },
});
