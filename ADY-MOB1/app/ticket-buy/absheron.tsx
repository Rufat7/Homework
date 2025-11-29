import React, { useState } from "react";
import {
  View,
  Text,
  TouchableOpacity,
  ScrollView,
  Platform,
  Animated,
  Alert,
} from "react-native";
import DateTimePicker from "@react-native-community/datetimepicker";
import { router, Stack } from "expo-router";

export const screenOptions = {
  title: "Absheron Ticket",
  headerBackTitle: "Назад",
};

export default function AbsheronTicket() {
  const totalSeats = 40;
  const seatPrice = 15;

  const locations = ["Baku", "Sumqayit", "Novxani", "Goredil", "Pirsagi", "Koroglu"];
  const schedule: { [key: string]: string[] } = {
    Baku: ["07:50", "12:30", "18:00"],
    Sumqayit: ["08:30", "14:00", "19:00"],
    Novxani: ["08:50", "14:30", "19:30"],
    Goredil: ["09:10", "15:00", "20:00"],
    Pirsagi: ["09:40", "15:30", "20:30"],
    Koroglu: ["10:00", "16:00", "21:00"],
  };

  const [from, setFrom] = useState("");
  const [to, setTo] = useState("");
  const [date, setDate] = useState(new Date());
  const [showDatePicker, setShowDatePicker] = useState(false);
  const [time, setTime] = useState("");
  const [selectedSeats, setSelectedSeats] = useState<number[]>([]);

  const [showFromDropdown, setShowFromDropdown] = useState(false);
  const [showToDropdown, setShowToDropdown] = useState(false);
  const [showTimeDropdown, setShowTimeDropdown] = useState(false);

  const seatRows: number[][] = [];
  for (let i = 1; i <= totalSeats; i += 4) seatRows.push([i, i + 1, i + 2, i + 3]);

  const toggleSeat = (seat: number) => {
    setSelectedSeats(prev =>
      prev.includes(seat) ? prev.filter(s => s !== seat) : [...prev, seat]
    );
  };

  const onChangeDate = (event: any, selected?: Date) => {
    const currentDate = selected || date;
    setShowDatePicker(Platform.OS === "ios");
    setDate(currentDate);
  };

  const Seat = ({ n }: { n: number }) => {
    const isSelected = selectedSeats.includes(n);
    const animated = new Animated.Value(isSelected ? 1 : 0.9);

    Animated.spring(animated, {
      toValue: isSelected ? 1 : 0.9,
      useNativeDriver: true,
    }).start();

    return (
      <Animated.View style={{ transform: [{ scale: animated }] }}>
        <TouchableOpacity
          onPress={() => toggleSeat(n)}
          style={{
            width: 48,
            height: 48,
            marginHorizontal: 8,
            borderRadius: 12,
            backgroundColor: isSelected ? "#1d5c87" : "#e5e7eb",
            justifyContent: "center",
            alignItems: "center",
            shadowColor: "#000",
            shadowOpacity: 0.15,
            shadowRadius: 4,
            elevation: 4,
          }}
        >
          <Text style={{ color: isSelected ? "#fff" : "#333", fontWeight: "bold" }}>{n}</Text>
        </TouchableOpacity>
      </Animated.View>
    );
  };

  const Card = ({ text, selected, onPress }: any) => (
    <TouchableOpacity
      onPress={onPress}
      style={{
        paddingVertical: 12,
        paddingHorizontal: 18,
        marginVertical: 4,
        borderRadius: 12,
        backgroundColor: selected ? "#1d5c87" : "#fff",
        borderWidth: 1,
        borderColor: selected ? "#1d5c87" : "#ccc",
      }}
    >
      <Text style={{ color: selected ? "#fff" : "#333", fontWeight: "bold" }}>{text}</Text>
    </TouchableOpacity>
  );

  const validateBooking = () => {
    if (!from || !to || !time || selectedSeats.length === 0) {
      Alert.alert("Ошибка", "Пожалуйста, заполните все поля и выберите место");
      return false;
    }
    return true;
  };

  return (
    <ScrollView contentContainerStyle={{ padding: 20, backgroundColor: "#fff" }}>
      <Text style={{ fontWeight: "bold", marginBottom: 8 }}>Откуда</Text>
      <TouchableOpacity
        onPress={() => setShowFromDropdown(!showFromDropdown)}
        style={{
          padding: 14,
          borderRadius: 12,
          borderWidth: 1,
          borderColor: "#ccc",
          marginBottom: 10,
        }}
      >
        <Text>{from || "Выберите город"}</Text>
      </TouchableOpacity>
      {showFromDropdown && (
        <View style={{ marginBottom: 10 }}>
          {locations.filter(l => l !== to).map(l => (
            <Card
              key={l}
              text={l}
              selected={from === l}
              onPress={() => {
                setFrom(l);
                setTime(schedule[l][0]);
                setShowFromDropdown(false);
                if (l === to) setTo("");
              }}
            />
          ))}
        </View>
      )}

      <Text style={{ fontWeight: "bold", marginBottom: 8 }}>Куда</Text>
      <TouchableOpacity
        onPress={() => setShowToDropdown(!showToDropdown)}
        style={{
          padding: 14,
          borderRadius: 12,
          borderWidth: 1,
          borderColor: "#ccc",
          marginBottom: 10,
        }}
      >
        <Text>{to || "Выберите город"}</Text>
      </TouchableOpacity>
      {showToDropdown && (
        <View style={{ marginBottom: 10 }}>
          {locations.filter(l => l !== from).map(l => (
            <Card
              key={l}
              text={l}
              selected={to === l}
              onPress={() => {
                setTo(l);
                setShowToDropdown(false);
                if (l === from) setFrom("");
              }}
            />
          ))}
        </View>
      )}

      <Text style={{ fontWeight: "bold", marginBottom: 8 }}>Дата</Text>
      <TouchableOpacity
        onPress={() => setShowDatePicker(true)}
        style={{
          padding: 14,
          borderRadius: 12,
          borderWidth: 1,
          borderColor: "#ccc",
          marginBottom: 20,
        }}
      >
        <Text>{date.toLocaleDateString()}</Text>
      </TouchableOpacity>
      {showDatePicker && (
        <DateTimePicker value={date} mode="date" display="default" onChange={onChangeDate} />
      )}

      {from !== "" && (
        <>
          <Text style={{ fontWeight: "bold", marginBottom: 8 }}>Время</Text>
          <TouchableOpacity
            onPress={() => setShowTimeDropdown(!showTimeDropdown)}
            style={{
              padding: 14,
              borderRadius: 12,
              borderWidth: 1,
              borderColor: "#ccc",
              marginBottom: 10,
            }}
          >
            <Text>{time || "Выберите время"}</Text>
          </TouchableOpacity>
          {showTimeDropdown && (
            <View style={{ marginBottom: 20 }}>
              {schedule[from].map(t => (
                <Card
                  key={t}
                  text={t}
                  selected={time === t}
                  onPress={() => {
                    setTime(t);
                    setShowTimeDropdown(false);
                  }}
                />
              ))}
            </View>
          )}
        </>
      )}

      <Text style={{ fontWeight: "bold", marginBottom: 12, marginTop: 10 }}>Выберите место</Text>
      <View style={{ alignItems: "center", marginBottom: 30 }}>
        {seatRows.map((row, idx) => (
          <View
            key={idx}
            style={{ flexDirection: "row", alignItems: "center", marginBottom: 12 }}
          >
            <Seat n={row[0]} />
            <Seat n={row[1]} />
            <View style={{ width: 28 }} />
            <Seat n={row[2]} />
            <Seat n={row[3]} />
          </View>
        ))}
      </View>

      {selectedSeats.length > 0 && (
        <View style={{ alignItems: "center", marginBottom: 20 }}>
          <Text style={{ fontWeight: "bold" }}>Вы выбрали:</Text>
          <Text
            style={{
              marginTop: 6,
              fontWeight: "bold",
              fontSize: 16,
              color: "#1d5c87",
            }}
          >
            {selectedSeats.join(", ")}
          </Text>
          <Text style={{ marginTop: 10, fontWeight: "bold", fontSize: 18 }}>
            Сумма: {selectedSeats.length * seatPrice} ₼
          </Text>
        </View>
      )}

      <TouchableOpacity
        onPress={() => {
          if (!validateBooking()) return;
          router.push({
            pathname: "/ticket-buy/ticket-success",
            params: {
              from,
              to,
              date: date.toLocaleDateString(),
              time,
              seats: selectedSeats.join(","),
              total: selectedSeats.length * seatPrice,
            },
          });
        }}
        style={{
          backgroundColor:
            !from || !to || !time || selectedSeats.length === 0 ? "#94a3b8" : "#1d5c87",
          paddingVertical: 16,
          borderRadius: 12,
          alignItems: "center",
          marginBottom: 30,
        }}
      >
        <Text style={{ color: "#fff", fontWeight: "bold", fontSize: 18 }}>Купить</Text>
      </TouchableOpacity>
    </ScrollView>
  );
}
