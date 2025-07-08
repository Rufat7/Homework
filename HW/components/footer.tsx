import { StyleSheet, Text, View, TouchableOpacity } from "react-native";
import React from "react";
import { SafeAreaView } from "react-native-safe-area-context";
import { router, usePathname } from "expo-router";
import Ionicons from "@expo/vector-icons/Ionicons";
import MaterialIcons from "@expo/vector-icons/MaterialIcons";
import { theme } from "../constants/theme";

const AuthFooter = () => {
  const pathname = usePathname();

  return (
    <SafeAreaView edges={["bottom"]}>
      <View style={styles.bottomNav}>
        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/home")}
        >
          <Ionicons name="home" size={26} color={theme.colors.primary} />
          <Text style={styles.navLabelActive}>Home</Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/assets")}
        >
          <MaterialIcons name="analytics" size={26} color="gray" />
          <Text style={styles.navLabel}>Assets</Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={[styles.navItem, styles.centerSwap]}
          onPress={() => router.push("/(auth)/(footerview)/swap")}
        >
          <View style={styles.centerSwapIcon}>
            <Ionicons name="swap-vertical-outline" size={26} color="gray" />
          </View>
          <Text style={styles.navLabelCenter}>Swap</Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/history")}
        >
          <Ionicons name="time-outline" size={26} color="gray" />
          <Text style={styles.navLabel}>History</Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/settings")}
        >
          <Ionicons name="settings-outline" size={26} color="gray" />
          <Text style={styles.navLabel}>Settings</Text>
        </TouchableOpacity>
      </View>
    </SafeAreaView>
  );
};

export default AuthFooter;

const styles = StyleSheet.create({
  bottomNav: {
    flexDirection: "row",
    justifyContent: "space-around",
    alignItems: "center",
    height: 80,
    backgroundColor: "white",
    borderTopWidth: 1,
    borderColor: "#eee",
  },
  navItem: {
    alignItems: "center",
    justifyContent: "center",
  },
  navLabel: {
    fontSize: 12,
    color: "gray",
  },
  navLabelActive: {
    fontSize: 12,
    color: theme.colors.primary,
    fontWeight: "600",
  },
  centerSwap: {
    alignItems: "center",
    justifyContent: "center",
    marginTop: -10,
  },
  centerSwapIcon: {
    backgroundColor: "transparent",
    borderRadius: 30,
    padding: 0,
  },
  navLabelCenter: {
    fontSize: 12,
    color: "gray",
    fontWeight: "600",
    marginTop: 4,
  },
});