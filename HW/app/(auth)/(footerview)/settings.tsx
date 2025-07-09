import React from 'react';
import { View, Text, TouchableOpacity, StyleSheet, ScrollView, SafeAreaView } from 'react-native';
import Ionicons from '@expo/vector-icons/Ionicons';
import { router } from 'expo-router'; 

const SettingsScreen = () => {
  const handleLogout = () => {
    router.push('/(auth)/(tabview)/login');
  };

  return (
    <SafeAreaView style={styles.container}>
      <ScrollView contentContainerStyle={styles.scroll}>
        <Text style={styles.header}>Settings</Text>

        <TouchableOpacity style={styles.verifyBox}>
          <Ionicons name="rocket-outline" size={32} color="white" style={styles.verifyIcon} />
          <View>
            <Text style={styles.verifyText}>Verify your identity</Text>
            <Text style={styles.verifySubtext}>Confirm to unlock features</Text>
          </View>
        </TouchableOpacity>

        <View style={styles.section}>
          <SettingItem icon="person-outline" label="Profile" />
          <SettingItem icon="shield-checkmark-outline" label="Security" />
          <SettingItem icon="language-outline" label="Language" />
          <SettingItem icon="notifications-outline" label="Notifications" />
          <SettingItem icon="help-circle-outline" label="Help & Feedback" />
          <SettingItem icon="document-text-outline" label="Legal & Terms" />
        </View>

        <TouchableOpacity style={styles.logoutContainer} onPress={handleLogout}>
          <Ionicons name="log-out-outline" size={26} color="#FF3B30" />
          <Text style={styles.logoutText}>Log Out</Text>
        </TouchableOpacity>
      </ScrollView>
    </SafeAreaView>
  );
};

type SettingItemProps = {
  icon: string;
  label: string;
};

const SettingItem: React.FC<SettingItemProps> = ({ icon, label }) => (
  <TouchableOpacity style={styles.item}>
    <View style={styles.itemLeft}>
      <Ionicons name={icon} size={24} color="#555" />
      <Text style={styles.itemText}>{label}</Text>
    </View>
    <Ionicons name="chevron-forward" size={24} color="#999" />
  </TouchableOpacity>
);

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
  },
  scroll: {
    paddingHorizontal: 24,
    paddingTop: 80,
    paddingBottom: 60,
  },
  header: {
    fontSize: 28,
    fontWeight: '700',
    textAlign: 'center',
    marginBottom: 40,
  },
  verifyBox: {
    flexDirection: 'row',
    backgroundColor: '#0057FF',
    padding: 20,
    borderRadius: 16,
    alignItems: 'center',
    marginBottom: 50,
  },
  verifyIcon: {
    marginRight: 16,
  },
  verifyText: {
    color: '#fff',
    fontWeight: '700',
    fontSize: 20,
  },
  verifySubtext: {
    color: '#d0dfff',
    fontSize: 15,
    marginTop: 4,
  },
  section: {
    marginBottom: 30,
  },
  item: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    paddingVertical: 22,
    borderBottomWidth: 1,
    borderColor: '#f0f0f0',
  },
  itemLeft: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  itemText: {
    marginLeft: 16,
    fontSize: 18,
    color: '#333',
    fontWeight: '500',
  },
  logoutContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    marginTop: 20, 
  },
  logoutText: {
    color: '#FF3B30',
    fontSize: 18,
    marginLeft: 10,
    fontWeight: '600',
  },
});

export default SettingsScreen;
