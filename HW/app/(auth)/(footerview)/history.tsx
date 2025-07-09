import React from 'react';
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  SafeAreaView,
  TouchableOpacity,
} from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { router } from 'expo-router';

const transactions = [
  {
    date: '27 Feb 2025',
    data: [
      { type: 'Transferred', time: '2:01 PM', amount: '-58 TRX', color: 'red', icon: 'arrow-up-outline' },
      { type: 'Received', time: '3:24 PM', amount: '+5 SOL', color: 'green', icon: 'arrow-down-outline' },
    ],
  },
  {
    date: '26 Feb 2025',
    data: [
      { type: 'Transferred', time: '2:01 PM', amount: '-58 TRX', color: 'red', icon: 'arrow-up-outline' },
      { type: 'Received', time: '3:24 PM', amount: '+5 SOL', color: 'green', icon: 'arrow-down-outline' },
    ],
  },
  {
    date: '25 Feb 2025',
    data: [
      { type: 'Transferred', time: '2:01 PM', amount: '-58 TRX', color: 'red', icon: 'arrow-up-outline' },
      { type: 'Received', time: '3:24 PM', amount: '+5 SOL', color: 'green', icon: 'arrow-down-outline' },
    ],
  },
  {
    date: '24 Feb 2025',
    data: [
      { type: 'Received', time: '3:24 PM', amount: '+5 SOL', color: 'green', icon: 'arrow-down-outline' },
      { type: 'Transferred', time: '2:01 PM', amount: '-58 TRX', color: 'red', icon: 'arrow-up-outline' },
    ],
  },
];

const ActivityScreen = () => {
  return (
    <View style={{ flex: 1, backgroundColor: '#fff' }}>
      <SafeAreaView style={styles.container}>
        <View style={styles.headerWrapper}>
          <Text style={styles.headerText}>Activity</Text>
        </View>

        <View style={styles.spentContainer}>
          <TouchableOpacity style={styles.spentRow}>
            <Ionicons name="cash-outline" size={24} color="#5570F1" />
            <Text style={styles.spentLabel}>Total spent in Feb</Text>
          </TouchableOpacity>
          <Text style={styles.spentAmount}>$ 22,870</Text>
          <View style={styles.progressBackground}>
            <View style={styles.progressBar} />
          </View>
          <Text style={styles.limitText}>Monthly spending limit: $30,000</Text>
        </View>

        <View style={styles.historyHeader}>
          <Text style={styles.historyTitle}>Transaction History</Text>
          <TouchableOpacity style={styles.filterButton}>
            <Text style={styles.filterText}>By Date</Text>
            <Ionicons name="filter-outline" size={20} color="#5570F1" />
          </TouchableOpacity>
        </View>

        <ScrollView
          style={styles.historyList}
          contentContainerStyle={{ paddingBottom: 80 }}
        >
          {transactions.map((section, index) => (
            <View key={index}>
              <Text style={styles.transactionDate}>{section.date}</Text>
              {section.data.map((tx, idx) => (
                <TouchableOpacity
                  key={idx}
                  style={styles.transactionRow}
                  onPress={() =>
                    router.push({
                      pathname: '/(auth)/(footerview)/screens/ReceiptScreen',
                      params: {
                        txId: `0x7aQvc...9t0`,
                        status: tx.type === 'Transferred' ? 'Paid' : 'Received',
                        time: `${section.date}, ${tx.time}`,
                        amount: tx.amount.replace(/[^0-9.]/g, ''),
                        fee: '12.41',
                      },
                    })
                  }
                >
                  <View
                    style={[
                      styles.iconCircle,
                      {
                        backgroundColor: tx.color === 'red' ? '#FFE5E5' : '#E6F6EF',
                      },
                    ]}
                  >
                    <Ionicons
                      name={tx.icon}
                      size={28}
                      color={tx.color === 'red' ? '#FF4C4C' : '#00C48C'}
                    />
                  </View>
                  <View style={styles.transactionInfo}>
                    <Text style={styles.transactionType}>{tx.type}</Text>
                    <Text style={styles.transactionTime}>{tx.time}</Text>
                  </View>
                  <Text
                    style={[
                      styles.transactionAmount,
                      {
                        color: tx.color === 'red' ? '#FF4C4C' : '#00C48C',
                      },
                    ]}
                  >
                    {tx.amount}
                  </Text>
                </TouchableOpacity>
              ))}
            </View>
          ))}
        </ScrollView>
      </SafeAreaView>
    </View>
  );
};

export default ActivityScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'transparent',
    paddingHorizontal: 32,
    marginTop: 64,
  },
  headerWrapper: {
    paddingTop: 12,
    marginBottom: 12,
    alignItems: 'center',
  },
  headerText: {
    fontSize: 24,
    fontWeight: '600',
  },
  spentContainer: {
    marginBottom: 24,
  },
  spentRow: {
    flexDirection: 'row',
    alignItems: 'center',
    columnGap: 8,
  },
  spentLabel: {
    color: '#5570F1',
    fontSize: 18,
    fontWeight: '500',
  },
  spentAmount: {
    fontSize: 40,
    fontWeight: 'bold',
    marginVertical: 10,
  },
  progressBackground: {
    width: '100%',
    height: 8,
    backgroundColor: '#E5EAF0',
    borderRadius: 8,
  },
  progressBar: {
    width: '75%',
    height: '100%',
    backgroundColor: '#5570F1',
    borderRadius: 8,
  },
  limitText: {
    fontSize: 16,
    color: '#8F9BB3',
    marginTop: 8,
  },
  historyHeader: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginBottom: 10,
  },
  historyTitle: {
    fontSize: 20,
    fontWeight: '600',
  },
  filterButton: {
    flexDirection: 'row',
    alignItems: 'center',
    columnGap: 6,
  },
  filterText: {
    color: '#5570F1',
    fontSize: 18,
    fontWeight: '500',
  },
  historyList: {
    flex: 1,
    marginBottom: 24,
    marginHorizontal: -32,
    paddingRight: 32,
  },
  transactionDate: {
    fontSize: 16,
    color: '#8F9BB3',
    marginVertical: 10,
    paddingLeft: 32,
  },
  transactionRow: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingVertical: 12,
    paddingLeft: 32,
  },
  iconCircle: {
    width: 48,
    height: 48,
    borderRadius: 24,
    justifyContent: 'center',
    alignItems: 'center',
    marginRight: 16,
  },
  transactionInfo: {
    flex: 1,
  },
  transactionType: {
    fontSize: 18,
    fontWeight: '500',
  },
  transactionTime: {
    fontSize: 16,
    color: '#8F9BB3',
  },
  transactionAmount: {
    fontWeight: '600',
    fontSize: 18,
  },
});
