import { StyleSheet, Text, View, TouchableOpacity } from "react-native";
import React from "react";
import { SafeAreaView } from "react-native-safe-area-context";
import { router, usePathname } from "expo-router";
import Ionicons from "@expo/vector-icons/Ionicons";
import MaterialIcons from "@expo/vector-icons/MaterialIcons";

export default function Footer() {
  const pathname = usePathname();
  console.log("Current pathname:", pathname);

  return (
    <SafeAreaView edges={["bottom"]}>
      <View style={styles.bottomNav}>
        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/home")}
        >
          <Ionicons
            name="home"
            size={26}
            color={pathname.includes("/home") ? '#003CFF' : 'gray'}
          />
          <Text style={pathname.includes("/home") ? styles.navLabelActive : styles.navLabel}>
            Home
          </Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/assets")}
        >
          <MaterialIcons
            name="analytics"
            size={26}
            color={pathname.includes("/assets") ? '#003CFF' : 'gray'}
          />
          <Text style={pathname.includes("/assets") ? styles.navLabelActive : styles.navLabel}>
            Assets
          </Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/swap")}
        >
          <Ionicons
            name="swap-vertical-outline"
            size={26}
            color={pathname.includes("/swap") ? '#003CFF' : 'gray'}
          />
          <Text style={pathname.includes("/swap") ? styles.navLabelActive : styles.navLabelCenter}>
            Swap
          </Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/history")}
        >
          <Ionicons
            name="time-outline"
            size={26}
            color={pathname.includes("/history") ? '#003CFF' : 'gray'}
          />
          <Text style={pathname.includes("/history") ? styles.navLabelActive : styles.navLabel}>
            History
          </Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.navItem}
          onPress={() => router.push("/(auth)/(footerview)/settings")}
        >
          <Ionicons
            name="settings-outline"
            size={26}
            color={pathname.includes("/settings") ? '#003CFF' : 'gray'}
          />
          <Text style={pathname.includes("/settings") ? styles.navLabelActive : styles.navLabel}>
            Settings
          </Text>
        </TouchableOpacity>
      </View>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  bottomNav: {
    marginBottom: -35,
    paddingBottom: 20,
    flexDirection: "row",
    justifyContent: "space-around",
    alignItems: "center",
    height: 90,
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
    color: '#003CFF',
    fontWeight: "600",
  },
  navLabelCenter: {
    fontSize: 12,
    color: "gray",
    fontWeight: "600",
    marginTop: 4,
  },
});