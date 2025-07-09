import React from 'react';
import {
  View,
  Text,
  StyleSheet,
  SafeAreaView,
  TouchableOpacity,
} from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { useLocalSearchParams, useRouter } from 'expo-router';

const ReceiptScreen = () => {
  const router = useRouter();
  const { txId, status, time, amount, fee } = useLocalSearchParams();

  const getString = (param: string | string[] | undefined): string =>
    Array.isArray(param) ? param[0] ?? '0' : param ?? '0';

  const total = (
    parseFloat(getString(amount)) + parseFloat(getString(fee))
  ).toFixed(2);

  return (
    <SafeAreaView style={styles.container}>
      <TouchableOpacity onPress={() => router.push('/history')} style={styles.backButton}>
        <Ionicons name="arrow-back" size={24} color="black" />
      </TouchableOpacity>

      <Text style={styles.title}>Receipt</Text>

      <View style={styles.iconWrapper}>
        <View style={styles.iconCircle}>
          <Ionicons name="flash-outline" size={28} color="#fff" />
        </View>
      </View>

      <Text style={styles.successText}>Payment Success!</Text>
      <Text style={styles.subText}>Your payment has been successfully done.</Text>

      <View style={styles.card}>
        <View style={styles.divider} />
        <Text style={styles.cardTitle}>Payment Details</Text>

        <View style={styles.row}>
          <Text style={styles.label}>Transaction ID</Text>
          <Text style={styles.value}>{getString(txId)}</Text>
        </View>

        <View style={styles.row}>
          <Text style={styles.label}>Payment Status</Text>
          <Text style={[styles.status, { color: 'green' }]}>● Paid</Text>
        </View>

        <View style={styles.row}>
          <Text style={styles.label}>Payment Time</Text>
          <Text style={styles.value}>{getString(time)}</Text>
        </View>

        <View style={styles.divider} />

        <View style={styles.row}>
          <Text style={styles.label}>Sent Amount</Text>
          <Text style={styles.value}>USDT {getString(amount)}</Text>
        </View>

        <View style={styles.row}>
          <Text style={styles.label}>Network Fee</Text>
          <Text style={styles.value}>USDT {getString(fee)}</Text>
        </View>

        <View style={styles.totalRow}>
          <Text style={styles.totalText}>Total Payment</Text>
        </View>
        <Text style={styles.totalAmount}>USDT {total}</Text>
      </View>
    </SafeAreaView>
  );
};

export default ReceiptScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 24,
    paddingTop: 80,
    backgroundColor: '#fff',
  },
  backButton: {
    position: 'absolute',
    top: 90,  
    left: 24,
    zIndex: 10,
  },
  title: {
    fontSize: 20,
    fontWeight: '600',
    textAlign: 'center',
    marginVertical: 16,
  },
  iconWrapper: {
    alignItems: 'center',
    marginVertical: 12,
  },
  iconCircle: {
    backgroundColor: '#2E5BFF',
    width: 64,
    height: 64,
    borderRadius: 32,
    justifyContent: 'center',
    alignItems: 'center',
  },
  successText: {
    fontSize: 20,
    fontWeight: '600',
    textAlign: 'center',
  },
  subText: {
    textAlign: 'center',
    color: '#6B7280',
    marginBottom: 20,
  },
  card: {
    backgroundColor: '#F9FAFB',
    borderRadius: 16,
    padding: 16,
    marginTop: 12,
  },
  cardTitle: {
    fontWeight: '600',
    fontSize: 16,
    marginBottom: 12,
  },
  row: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginBottom: 16,
  },
  label: {
    color: '#6B7280',
    fontSize: 14,
  },
  value: {
    fontSize: 14,
    fontWeight: '500',
  },
  status: {
    fontSize: 14,
    fontWeight: '500',
  },
  divider: {
    borderTopWidth: 1,
    borderColor: '#E5E7EB',
    marginVertical: 16,
  },
  totalRow: {
    borderTopWidth: 1,
    borderColor: '#E5E7EB',
    marginTop: 16,
    paddingTop: 12,
    alignItems: 'center',
  },
  totalText: {
    fontSize: 16,
    fontWeight: '600',
  },
  totalAmount: {
    fontSize: 20,
    fontWeight: '700',
    textAlign: 'center',
    marginTop: 8,
  },
});
