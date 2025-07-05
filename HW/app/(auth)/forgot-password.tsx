import {
  StyleSheet,
  Text,
  TextInput,
  View,
  TouchableOpacity,
} from "react-native";
import React, { useState } from "react";
import { SafeAreaView } from "react-native-safe-area-context";
import { Image } from "expo-image";
import { theme } from "../../constants/theme";
import { router } from "expo-router";

const ForgotPassword = () => {
  const [email, setEmail] = useState("");

  const validateEmail = (email: string) => {
    const re =
      /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(email.toLowerCase());
  };

  const isEmailValid = validateEmail(email);

  return (
    <SafeAreaView style={styles.container}>
      <View style={styles.mainContainer}>
        <Image
          source={require("../../assets/Logo.svg")}
          contentFit="contain"
          style={styles.logo}
        />

        <View style={styles.textContainer}>
          <Text style={styles.titleText}>Reset Password</Text>
          <Text style={styles.subtitleText}>
            We'll send you an email with a password reset link.
          </Text>
        </View>

        <View style={styles.labelWrapper}>
          <Text style={styles.labelText}>Email</Text>
        </View>

        <View style={styles.inputWrapper}>
          <TextInput
            placeholder=""
            placeholderTextColor="#A0AEC0"
            value={email}
            onChangeText={setEmail}
            style={styles.input}
            keyboardType="email-address"
            autoCapitalize="none"
            autoCorrect={false}
          />
        </View>

        <View style={styles.flexSpacer} />

        <View style={styles.buttonContainer}>
          <View style={styles.resendContainer}>
            <Text style={styles.resendStaticText}>Didn't get a code? </Text>
            <TouchableOpacity>
              <Text style={styles.resendText}>Click to resend</Text>
            </TouchableOpacity>
          </View>

          <View style={styles.divider} />

          <View style={styles.actionButtonsContainer}>
            <TouchableOpacity
              onPress={() => router.push("/(auth)/(tabview)/login")}
              style={styles.button}
            >
              <Text style={styles.buttonText}>Back</Text>
            </TouchableOpacity>

            <TouchableOpacity
              disabled={!isEmailValid}
              style={[
                styles.button,
                styles.sendButton,
              ]}
              onPress={() => router.push("/(auth)/email-successfull")}
            >
              <Text style={styles.sendButtonText}>Send</Text>
            </TouchableOpacity>
          </View>
        </View>
      </View>
    </SafeAreaView>
  );
};

export default ForgotPassword;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "white",
  },
  mainContainer: {
    flex: 1,
    paddingTop: 80,
    paddingHorizontal: 16,
  },
  logo: {
    width: 64,
    height: 64,
    alignSelf: "center",
  },
  textContainer: {
    flexDirection: "column",
    gap: 12,
    paddingHorizontal: 40,
    marginTop: 24,
  },
  titleText: {
    fontFamily: "Poppins-SemiBold",
    fontSize: 20,
    color: "#19213D",
    textAlign: "center",
  },
  subtitleText: {
    fontFamily: "Poppins-Regular",
    fontSize: 16,
    color: "#5D6481",
    textAlign: "center",
  },
  labelWrapper: {
    marginTop: 24,
    marginBottom: 8,
  },
  labelText: {
    fontFamily: "Poppins-Medium",
    fontSize: 14,
    color: "#19213D",
  },
  inputWrapper: {
    borderWidth: 1,
    borderColor: "#EAEAEA",
    borderRadius: 14,
    backgroundColor: "#F8F9FA",
    paddingHorizontal: 16,
    height: 56,
    justifyContent: "center",
  },
  input: {
    fontSize: 16,
    fontFamily: "Poppins-Regular",
    color: "#19213D",
  },
  flexSpacer: {
    flex: 1,
  },
  buttonContainer: {
    flexDirection: "column",
    gap: 16,
    marginBottom: 32,
  },
  resendContainer: {
    flexDirection: "row",
    justifyContent: "center",
    alignItems: "center",
    gap: 4,
  },
  resendStaticText: {
    fontFamily: "Poppins-Regular",
    fontSize: 16,
    color: "#5D6481",
    textAlign: "center",
  },
  resendText: {
    fontFamily: "Poppins-Regular",
    fontSize: 16,
    color: theme.colors.primary,
    textAlign: "center",
  },
  divider: {
    borderBottomWidth: 1,
    borderBottomColor: "#EAEAEA",
    marginVertical: 8,
  },
  actionButtonsContainer: {
    flexDirection: "row",
    justifyContent: "space-between",
    paddingHorizontal: 16,
  },
  button: {
    paddingVertical: 12,
    paddingHorizontal: 55,
    marginTop: 14,
    borderRadius: 8,
    borderWidth: 1,
    borderColor: "#EAEAEA",
    backgroundColor: "#F8F9FA",
  },
  sendButton: {
    backgroundColor: theme.colors.primary,
    borderColor: theme.colors.primary,
  },
  sendButtonDisabled: {
    opacity: 0.5,
  },
  buttonText: {
    fontFamily: "Poppins-Medium",
    fontSize: 16,
    color: "#19213D",
  },
  sendButtonText: {
    fontFamily: "Poppins-Medium",
    fontSize: 16,
    color: "white",
  },
});
