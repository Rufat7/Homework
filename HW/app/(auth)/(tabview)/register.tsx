import {
  Pressable,
  StyleSheet,
  Text,
  TextInput,
  useWindowDimensions,
  View,
  Alert,
} from "react-native";
import React, { useState } from "react";
import { SafeAreaView } from "react-native-safe-area-context";
import { theme } from "../../../constants/theme";
import { router } from "expo-router";
import { useAuthStore } from "../../../store/authStore";

const Register = () => {
  const { width } = useWindowDimensions();
  const styles = getStyles(width);
  
  const [firstName, setFirstName] = useState('');
  const [lastName, setLastName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  
  const { register, isLoading, error, clearError } = useAuthStore();

  const validateForm = () => {
    if (!firstName || !lastName || !email || !password || !confirmPassword) {
      Alert.alert('Error', 'Please fill in all fields');
      return false;
    }

    if (password !== confirmPassword) {
      Alert.alert('Error', 'Passwords do not match');
      return false;
    }

    if (password.length < 6) {
      Alert.alert('Error', 'Password must be at least 6 characters long');
      return false;
    }

    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailRegex.test(email)) {
      Alert.alert('Error', 'Please enter a valid email address');
      return false;
    }

    return true;
  };

  const handleRegister = async () => {
    if (!validateForm()) return;

    const userData = {
      firstName,
      lastName,
      email,
      password,
    };

    const result = await register(userData);
    
    if (result.success) {
      Alert.alert(
        'Success', 
        'Registration successful!', 
        [
          { 
            text: 'OK', 
            onPress: () => router.push("/(auth)/otp") 
          }
        ]
      );
    } else {
      Alert.alert('Registration Error', result.error || 'Failed to register');
    }
  };

  return (
    <SafeAreaView style={styles.wrapper}>
      <View style={styles.content}>
        <View style={styles.nameRow}>
          <View>
            <Text style={styles.label}>First Name</Text>
            <TextInput
              style={[styles.input, styles.halfInput]}
              value={firstName}
              onChangeText={setFirstName}
              placeholder="First name"
              onFocus={clearError}
            />
          </View>
          <View>
            <Text style={styles.label}>Last Name</Text>
            <TextInput
              style={[styles.input, styles.halfInput]}
              value={lastName}
              onChangeText={setLastName}
              placeholder="Last name"
              onFocus={clearError}
            />
          </View>
        </View>

        <View style={styles.inputWrapper}>
          <Text style={styles.label}>Email</Text>
          <TextInput
            style={styles.input}
            value={email}
            onChangeText={setEmail}
            placeholder="Enter your email"
            keyboardType="email-address"
            autoCapitalize="none"
            onFocus={clearError}
          />
        </View>

        <View style={styles.inputWrapper}>
          <Text style={styles.label}>Set Password</Text>
          <TextInput
            style={styles.input}
            value={password}
            onChangeText={setPassword}
            placeholder="Enter password"
            secureTextEntry
            onFocus={clearError}
          />
        </View>

        <View style={styles.inputWrapper}>
          <Text style={styles.label}>Confirm Password</Text>
          <TextInput
            style={styles.input}
            value={confirmPassword}
            onChangeText={setConfirmPassword}
            placeholder="Confirm password"
            secureTextEntry
            onFocus={clearError}
          />
        </View>

        {error && (
          <View style={styles.errorContainer}>
            <Text style={styles.errorText}>{error}</Text>
          </View>
        )}

        <Pressable 
          style={[styles.registerButton, isLoading && styles.registerButtonDisabled]}
          onPress={handleRegister}
          disabled={isLoading}
        >
          <Text style={styles.registerButtonText}>
            {isLoading ? 'Registering...' : 'Register'}
          </Text>
        </Pressable>
      </View>
    </SafeAreaView>
  );
};

export default Register;

const getStyles = (width: number) =>
  StyleSheet.create({
    wrapper: {
      backgroundColor: "white",
      flex: 1,
      paddingTop: -90,
      alignItems: "center",
    },
    content: {
      width: width - 32,
      gap: 16,
    },
    nameRow: {
      flexDirection: "row",
      justifyContent: "space-between",
    },
    inputWrapper: {
      width: "100%",
    },
    label: {
      fontFamily: theme.fonts.regular,
      fontSize: 14,
      color: theme.colors.secondary,
      marginBottom: 8,
    },
    input: {
      width: "100%",
      borderColor: "#E0E0E0",
      borderWidth: 1,
      borderRadius: 8,
      paddingHorizontal: 12,
      paddingVertical: 12,
      fontSize: 16,
      fontFamily: theme.fonts.regular,
      backgroundColor: "#fff",
    },
    halfInput: {
      width: 180,
    },
    errorContainer: {
      backgroundColor: '#ffebee',
      padding: 12,
      borderRadius: 8,
      borderLeftWidth: 4,
      borderLeftColor: '#f44336',
    },
    errorText: {
      color: '#c62828',
      fontSize: 14,
      fontFamily: theme.fonts.regular,
    },
    registerButton: {
      width: "100%",
      backgroundColor: theme.colors.primary,
      paddingVertical: 14,
      borderRadius: 8,
      alignItems: "center",
      marginTop: 20,
    },
    registerButtonDisabled: {
      backgroundColor: theme.colors.grey,
    },
    registerButtonText: {
      color: theme.colors.white,
      fontSize: 16,
      fontFamily: theme.fonts.medium,
    },
  });