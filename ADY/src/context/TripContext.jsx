import React, { createContext, useContext, useState, useEffect } from "react";

const TripContext = createContext();

export const TripProvider = ({ children }) => {
  const [trip, setTrip] = useState(() => {
    try {
      const saved = sessionStorage.getItem("trip-data");
      return saved
        ? JSON.parse(saved)
        : {
            from: "",
            to: "",
            date: "",
            time: "",
            seats: [],
            totalPrice: 0,
            bookedSeats: [],
          };
    } catch {
      return {
        from: "",
        to: "",
        date: "",
        time: "",
        seats: [],
        totalPrice: 0,
        bookedSeats: [],
      };
    }
  });


  useEffect(() => {
    sessionStorage.setItem("trip-data", JSON.stringify(trip));
  }, [trip]);

  const updateTrip = (key, value) => {
    setTrip((prev) => {
      let updated = { ...prev, [key]: value };

  
      if (key === "seats") {
        updated.totalPrice = value.length * 15;
      }

      return updated;
    });
  };

  return (
    <TripContext.Provider value={{ trip, updateTrip }}>
      {children}
    </TripContext.Provider>
  );
};

export const useTrip = () => useContext(TripContext);
