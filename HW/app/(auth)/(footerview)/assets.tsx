import React, { useState } from "react";
import { View, Text, ScrollView, Image, TouchableOpacity } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";

type NewsItem = {
  id: number;
  source: string;
  image: any;
  logo: any;
  title: string;
  description: string;
  date: string;
};

export default function App() {
  const [selectedNews, setSelectedNews] = useState<NewsItem | null>(null);

  const newsData: NewsItem[] = [
    {
      id: 1,
      source: "CoinDesk",
      image: require("../../../assets/image.png"),
      logo: require("../../../assets/image copy 3.png"),
      title: "Bitcoin Bull Unleashed: Digital Titan Takes the Lead",
      description:
        "In a groundbreaking shift within the art world, the digital realm—often referred to as 'The Canvas'—is redefining how creativity and value intersect.\n\nOver the past year, crypto art sales have surged by over 300%, with artists leveraging blockchain technology to create, sell, and authenticate their work in entirely new ways.\n\nOne of the most notable developments came this week ...",
      date: "10 April, 2025",
    },
    {
      id: 2,
      source: "The Block",
      image: require("../../../assets/image copy.png"),
      logo: require("../../../assets/image copy 4.png"),
      title: "Ethereum Kills Fees: Gas Wars End",
      description:
        "Ethereum's latest upgrade has completely changed how transactions are prioritized and paid for. Gas fees have dropped significantly, creating new opportunities for adoption.",
      date: "9 April, 2025",
    },
    {
      id: 3,
      source: "Blockworks",
      image: require("../../../assets/image copy 2.png"),
      logo: require("../../../assets/image copy 5.png"),
      title: "Solana Reaches Historic TPS Milestone",
      description:
        "Solana has officially achieved over 100,000 transactions per second, setting a new standard in blockchain scalability.",
      date: "8 April, 2025",
    },
  ];

  return (
    <SafeAreaView className="flex-1 bg-[#FAFAFA]">
      {selectedNews ? (
        <ScrollView className="p-5">
          <View className="flex-row justify-between items-center mb-6">
            <TouchableOpacity onPress={() => setSelectedNews(null)}>
              <Text className="text-blue-600 font-bold text-lg">← Back</Text>
            </TouchableOpacity>
            <Text className="text-xl font-extrabold text-gray-800">News</Text>
            <View style={{ width: 50 }} />
          </View>

          <View className="flex-row items-center justify-between mb-5">
            <View className="flex-row items-center">
              <Image
                source={selectedNews.logo}
                className="w-8 h-8 mr-3 rounded-full"
              />
              <Text className="text-gray-700 font-bold text-lg flex-shrink">
                {selectedNews.source}
              </Text>
            </View>
            <Text className="text-base text-gray-500">{selectedNews.date}</Text>
          </View>

          <Image
            source={selectedNews.image}
            className="w-full h-80 rounded-3xl mb-6"
            resizeMode="cover"
          />

          <Text className="text-2xl font-extrabold text-gray-900 mb-4 leading-8">
            {selectedNews.title}
          </Text>

          <Text className="text-lg text-gray-700 leading-7">
            {selectedNews.description}
          </Text>

          <TouchableOpacity>
            <Text className="text-blue-600 mt-6 font-semibold text-lg">
              Read More
            </Text>
          </TouchableOpacity>
        </ScrollView>
      ) : (
        <ScrollView className="px-4">
          <View className="flex-row justify-between items-center my-6">
            <Text className="text-2xl font-extrabold text-gray-800">Top Coins</Text>
            <TouchableOpacity>
              <Text className="text-sm text-blue-600 font-bold">24H%</Text>
            </TouchableOpacity>
          </View>

          <View className="flex-row justify-between mb-10">
            <View
              className="w-[48%] h-[220px] p-6 rounded-2xl justify-between"
              style={{ backgroundColor: "#F4F6F8" }}
            >
              <View className="flex-row justify-between items-center">
                <Text className="text-gray-800 text-xl font-bold">DASH</Text>
                <Text className="text-green-500 font-bold text-lg">↑ 1.42%</Text>
              </View>
              <View className="flex-1 justify-center">
                <Text className="text-3xl font-extrabold text-left mt-2">
                  $22.29
                </Text>
              </View>
              <View className="flex-row items-center justify-center">
                <Image
                  source={{
                    uri: "https://cdn-icons-png.flaticon.com/512/825/825534.png",
                  }}
                  style={{ width: 30, height: 30 }}
                  resizeMode="contain"
                />
                <Text className="ml-3 text-gray-700 text-2xl font-bold">Dash</Text>
              </View>
            </View>

            <View
              className="w-[48%] h-[220px] p-6 rounded-2xl justify-between"
              style={{ backgroundColor: "#F6F6F6" }} 
            >
              <View className="flex-row justify-between items-center">
                <Text className="text-gray-800 text-xl font-bold">BTC</Text>
                <Text className="text-green-500 font-bold text-lg">↑ 2.79%</Text>
              </View>
              <View className="flex-1 justify-center">
                <Text className="text-3xl font-extrabold text-left mt-2">
                  $88,582.07
                </Text>
              </View>
              <View className="flex-row items-center justify-center">
                <Image
                  source={{
                    uri: "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Bitcoin.svg/2048px-Bitcoin.svg.png",
                  }}
                  style={{ width: 30, height: 30 }}
                  resizeMode="contain"
                />
                <Text className="ml-3 text-gray-700 text-2xl font-bold">Bitcoin</Text>
              </View>
            </View>
          </View>

          <View className="flex-row justify-between items-center mb-6">
            <Text className="text-2xl font-bold text-gray-800">News</Text>
            <TouchableOpacity>
              <Text className="text-blue-600 font-semibold text-base">View All</Text>
            </TouchableOpacity>
          </View>

          {newsData.map((item) => (
            <TouchableOpacity
              key={item.id}
              onPress={() => setSelectedNews(item)}
            >
              <View className="flex-row mb-6">
                <Image
                  source={item.image}
                  className="w-[130px] h-[130px] rounded-2xl"
                />
                <View className="flex-1 ml-4 justify-between">
                  <View>
                    <View className="flex-row items-center mb-1">
                      <Image
                        source={item.logo}
                        className="w-6 h-6 rounded-full mr-3"
                      />
                      <Text className="text-base text-gray-800 font-bold flex-shrink">
                        {item.source}
                      </Text>
                    </View>
                    <Text className="text-lg font-bold text-gray-800">
                      {item.title}
                    </Text>
                  </View>
                  <Text className="text-gray-400 text-sm mt-2">{item.date}</Text>
                </View>
              </View>
            </TouchableOpacity>
          ))}
        </ScrollView>
      )}
    </SafeAreaView>
  );
}
