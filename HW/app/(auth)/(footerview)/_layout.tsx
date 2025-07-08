import { Slot, Stack, Tabs } from "expo-router";
import { StyleSheet, Text, View } from "react-native";
import AuthTabs from "../../../components/auth-tabs";
import AuthFooter from "../../../components/footer";

const AuthFooterLayout = () => {
  return (
    <View className="flex-1">
     
      <Tabs
        screenOptions={{
          tabBarStyle: {
            display: "none",
          },
          animation: "shift",
          headerShown: false,
        }}
      >
        <Tabs.Screen
          options={{
            title: "Home",
          }}
          name="home"
        />
        <Tabs.Screen
          options={{
            title: "Assets",
          }}
          name="assets"
        />
         <Tabs.Screen
          options={{
            title: "Swap",
          }}
          name="swap"
        />
         <Tabs.Screen
          options={{
            title: "History",
          }}
          name="history"
        />
         <Tabs.Screen
          options={{
            title: "Settings",
          }}
          name="settings"
        />
      </Tabs>
       <AuthFooter />
    </View>
  );
};

export default AuthFooterLayout;

const styles = StyleSheet.create({});
