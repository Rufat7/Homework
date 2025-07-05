import React, { useEffect } from "react";
import { StyleSheet, Text, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { theme } from "../../constants/theme";
import { router } from "expo-router";

const EmailSuccess = () => {
  useEffect(() => {
    const timer = setTimeout(() => {
      router.push("/(auth)/(tabview)/login");
    }, 5000);

    return () => clearTimeout(timer);
  }, []);

  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.content}>
        <Text style={styles.title}>Email Sent Successfully!</Text>
        <Text style={styles.subtitle}>
          Check your inbox to reset your password
        </Text>
      </View>
    </SafeAreaView>
  );
};

export default EmailSuccess;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "white",
  },
  content: {
    flex: 1,
    paddingHorizontal: 24,
    justifyContent: "center",
    alignItems: "center",
  },
  title: {
    fontFamily: "Poppins-SemiBold",
    fontSize: 24,
    color: "#19213D",
    marginBottom: 12,
    textAlign: "center",
  },
  subtitle: {
    fontFamily: "Poppins-Regular",
    fontSize: 16,
    color: "#5D6481",
    textAlign: "center",
    marginBottom: 40,
    paddingHorizontal: 12,
  },
});
