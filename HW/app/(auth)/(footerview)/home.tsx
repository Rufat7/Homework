import React from "react";
import {
  View,
  Text,
  StyleSheet,
  TouchableOpacity,
  Image,
  ScrollView,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { Ionicons } from "@expo/vector-icons";
import { theme } from "../../../constants/theme";
import { router } from "expo-router";

const Home = () => {
  return (
    <SafeAreaView style={styles.container}>
      <ScrollView
        contentContainerStyle={styles.scrollContent}
        showsVerticalScrollIndicator={false}
      >
        <View style={styles.header}>
          <View style={styles.profileContainer}>
            <Image
              source={{
                uri: "https://img.freepik.com/free-vector/blue-circle-with-white-user_78370-4707.jpg?semt=ais_hybrid&w=740",
              }}
              style={styles.avatar}
            />
            <Text style={styles.profileName}>Lois Becket</Text>
          </View>
          <TouchableOpacity>
            <Ionicons name="notifications-outline" size={30} color="black" />
          </TouchableOpacity>
        </View>
        <View style={styles.balanceCard}>
          <View style={styles.circleWrapper}>
            {[...Array(21)].map((_, index) => {
              const angle = (Math.PI * index) / 20;
              const radius = 130;
              const x = radius * Math.cos(angle);
              const y = radius * Math.sin(angle);
              return (
                <View
                  key={`arc1-${index}`}
                  style={[
                    styles.dot,
                    {
                      position: "absolute",
                      top: radius - y,
                      left: x,
                      opacity: 0.3 + (0.7 * index) / 29,
                    },
                  ]}
                />
              );
            })}
            {[...Array(17)].map((_, index) => {
              const angle = (Math.PI * index) / 16;
              const radius = 90;
              const x = radius * Math.cos(angle);
              const y = radius * Math.sin(angle);
              return (
                <View
                  key={`arc2-${index}`}
                  style={[
                    styles.dot,
                    {
                      position: "absolute",
                      top: radius - y + 40,
                      left: x,
                      opacity: 0.2 + (0.6 * index) / 29,
                    },
                  ]}
                />
              );
            })}
          </View>
          <Ionicons
            name="flash"
            size={25}
            color="white"
            style={styles.flashIcon}
          />
          <Text style={styles.balanceText}>Balance in USDT</Text>
          <Text style={styles.balanceAmount}>$44,810</Text>

          <View style={styles.actionsRow}>
            <TouchableOpacity style={styles.actionButton}>
              <Ionicons
                name="arrow-down-outline"
                size={42}
                color="black"
              />
              <Text style={styles.actionLabel}>Deposit</Text>
            </TouchableOpacity>

            <TouchableOpacity style={styles.centerAction}>
              <View style={styles.swapIconWrapper}>
                <Ionicons name="swap-vertical" size={28} color="white" />
              </View>
              <Text style={styles.actionLabelSwap}>Swap</Text>
            </TouchableOpacity>

            <TouchableOpacity style={styles.actionButton}>
              <Ionicons
                name="arrow-up-outline"
                size={42}
                color="black"
              />
              <Text style={styles.actionLabel}>Send</Text>
            </TouchableOpacity>
          </View>
        </View>

        <View style={styles.portfolioSection}>
          <View style={styles.portfolioHeader}>
            <Text style={styles.portfolioTitle}>My Portfolio</Text>
            <TouchableOpacity>
              <Text style={styles.relevantText}>More Relevant</Text>
            </TouchableOpacity>
          </View>

          <View style={styles.assetCard}>
            <View style={styles.assetInfo}>
              <Image
                source={{
                  uri: "https://images.icon-icons.com/1487/PNG/512/8369-bitcoin_102502.png",
                }}
                style={styles.bitcoinLogo}
              />
              <View style={{ marginLeft: 5 }}>
                <Text style={styles.assetName}>Bitcoin</Text>
                <Text style={styles.assetSymbol}>BTC</Text>
              </View>
            </View>
            <View style={styles.assetStats}>
              <Text style={styles.assetValue}>$32,501.51</Text>
              <Text style={styles.assetGrowthPositive}>▲ 2.79%</Text>
            </View>
          </View>

          <View style={styles.assetCard}>
            <View style={styles.assetInfo}>
              <Image
                source={{
                  uri: "https://cdn4.iconfinder.com/data/icons/crypto-currency-and-coin-2/256/cardano_ada-512.png",
                }}
                style={styles.cryptoLogo}
              />
              <View style={{ marginLeft: 16 }}>
                <Text style={styles.assetName}>Cardano</Text>
                <Text style={styles.assetSymbol}>ADA</Text>
              </View>
            </View>
            <View style={styles.assetStats}>
              <Text style={styles.assetValue}>$12,308.49</Text>
              <Text style={styles.assetGrowthNegative}>▼ 8.21%</Text>
            </View>
          </View>
        </View>
      </ScrollView>
    </SafeAreaView>
  );
};

export default Home;

const styles = StyleSheet.create({
  container: { flex: 1, backgroundColor: "#f7f7f7" },
  scrollContent: { paddingBottom: 40 },
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    padding: 20,
  },
  profileContainer: { flexDirection: "row", alignItems: "center" },
  avatar: { width: 68, height: 68, borderRadius: 24, marginRight: 10 },
  profileName: { fontSize: 20, fontWeight: "600" },
  balanceCard: {
    borderRadius: 30,
    margin: 30,
    padding: 40,
    alignItems: "center",
  },
  circleWrapper: {
    top: -60,
    left: -10,
    right: 0,
    alignItems: "center",
    justifyContent: "center",
  },
  dot: {
    width: 14,
    height: 14,
    borderRadius: 7,
    backgroundColor: theme.colors.primary,
  },
  flashIcon: {
    backgroundColor: theme.colors.primary,
    padding: 15,
    borderRadius: 36,
    marginBottom: 12,
    marginTop: 30,
  },
  balanceText: { color: "gray", fontSize: 20, marginBottom: 25 },
  balanceAmount: {
    color: "black",
    fontSize: 42,
    fontWeight: "bold",
    marginBottom: 30,
  },
  actionsRow: {
    flexDirection: "row",
    justifyContent: "space-between",
    width: "100%",
    marginTop: 16,
  },
  actionButton: { alignItems: "center", flex: 1 },
  centerAction: { alignItems: "center", justifyContent: "center", flex: 1 },
  swapIconWrapper: {
    backgroundColor: theme.colors.primary,
    paddingHorizontal: 7,
    paddingVertical: 5,
    borderRadius: 18,
    justifyContent: "center",
    alignItems: "center",
    marginBottom: 4,
  },
  actionLabel: { marginTop: 6, fontSize: 16, fontWeight: "500" },
  actionLabelSwap: {
    marginTop: 6,
    fontSize: 16,
    fontWeight: "500",
  },
  portfolioSection: { marginTop: 10, paddingHorizontal: 20 },
  portfolioHeader: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 16,
    marginTop: -30,
  },
  portfolioTitle: { fontSize: 25, fontWeight: "600" },
  relevantText: { color: theme.colors.primary, fontSize: 20 },
  assetCard: {
    backgroundColor: "white",
    borderRadius: 16,
    padding: 20,
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 10,
  },
  assetInfo: { flexDirection: "row", alignItems: "center" },
  assetName: { fontSize: 18, fontWeight: "600" },
  assetSymbol: { fontSize: 16, color: "gray" },
  assetStats: { alignItems: "flex-end" },
  assetValue: { fontSize: 18, fontWeight: "600" },
  assetGrowthPositive: { color: "#10b981", fontSize: 16 },
  assetGrowthNegative: { color: "#ef4444", fontSize: 16 },
  bitcoinLogo: {
    width: 48,
    height: 48,
    left: -4,
    resizeMode: "contain",
  },
  cryptoLogo: {
    width: 36,
    height: 36,
    resizeMode: "contain",
  },
});