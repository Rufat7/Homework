"use client"

import { JSX, useState } from "react"
import Image from "next/image"
import { Sofa, ChefHat, UtensilsCrossed, Building2, Bed, DoorOpen } from "lucide-react"
import styles from "@/styles/furniture-filter.module.css"
import livingRoom from "@/images/livingRoom.jpg"
import office from "@/images/office.jpg"
import kitchen from "@/images/kitchen.jpg"
import diningRoom from "@/images/diningRoom.jpg"
import bedRoom from "@/images/bedRoom.jpg"
import hallway from "@/images/hallway.jpg"

type FilterType = "room" | "category" | "style"
type RoomType = "living" | "kitchen" | "dining" | "office" | "bedroom" | "hallway"

interface FilterItem {
  id: string
  name: string
  icon?: JSX.Element
}


const roomImages: Record<RoomType, typeof office> = {
  living: livingRoom,
  kitchen: kitchen,
  dining: diningRoom,
  office: office,
  bedroom: bedRoom,
  hallway: hallway,
}

export default function FurnitureFilter() {
  const [activeFilter, setActiveFilter] = useState<FilterType>("room")
  const [selectedRoom, setSelectedRoom] = useState<RoomType>("living")

  
  const roomData: FilterItem[] = [
    { id: "living", name: "Living Room", icon: <Sofa className={styles.icon} /> },
    { id: "kitchen", name: "Kitchen", icon: <ChefHat className={styles.icon} /> },
    { id: "dining", name: "Dining Room", icon: <UtensilsCrossed className={styles.icon} /> },
    { id: "office", name: "Office", icon: <Building2 className={styles.icon} /> },
    { id: "bedroom", name: "Bed Room", icon: <Bed className={styles.icon} /> },
    { id: "hallway", name: "Hallway", icon: <DoorOpen className={styles.icon} /> },
  ]

  const categoryData: FilterItem[] = [
    { id: "chairs", name: "Chairs" },
    { id: "tables", name: "Tables" },
    { id: "sofas", name: "Sofas" },
    { id: "storage", name: "Storage" },
    { id: "beds", name: "Beds" },
    { id: "lighting", name: "Lighting" },
  ]

  const styleData: FilterItem[] = [
    { id: "modern", name: "Modern" },
    { id: "scandinavian", name: "Scandinavian" },
    { id: "industrial", name: "Industrial" },
    { id: "classic", name: "Classic" },
    { id: "minimalist", name: "Minimalist" },
    { id: "rustic", name: "Rustic" },
  ]

  
  const getFilterData = (): FilterItem[] => {
    switch (activeFilter) {
      case "room":
        return roomData
      case "category":
        return categoryData
      case "style":
        return styleData
      default:
        return roomData
    }
  }

  const getRoomImage = () => {
    return roomImages[selectedRoom] || livingRoom 
  }

  
  const handleItemClick = (id: string) => {
    if (activeFilter === "room") {
      setSelectedRoom(id as RoomType)
    }
  }

  return (
    <div className={styles.container}>
      <h1 className={styles.title}>All Furniture</h1>

            <div className={styles.tabs}>
        <button
          className={`${styles.tab} ${activeFilter === "room" ? styles.activeTab : ""}`}
          onClick={() => setActiveFilter("room")}
        >
          Shop By Room
        </button>
        <button
          className={`${styles.tab} ${activeFilter === "category" ? styles.activeTab : ""}`}
          onClick={() => setActiveFilter("category")}
        >
          Shop By Category
        </button>
        <button
          className={`${styles.tab} ${activeFilter === "style" ? styles.activeTab : ""}`}
          onClick={() => setActiveFilter("style")}
        >
          Shop By Style
        </button>
      </div>

     
      <div className={styles.content}>
      
        <div className={styles.imageContainer}>
          <Image
            src={getRoomImage()}
            alt={`${selectedRoom} room`}
            fill
            className={styles.roomImage}
            priority={selectedRoom === "living"} 
          />
        </div>

   
        <div className={styles.grid}>
          {getFilterData().map((item) => (
            <button
              key={item.id}
              className={`${styles.gridItem} ${
                activeFilter === "room" && selectedRoom === item.id ? styles.activeGridItem : ""
              }`}
              onClick={() => handleItemClick(item.id)}
            >
              <div className={styles.iconContainer}>
                {item.icon || <span className={styles.itemInitial}>{item.name[0]}</span>}
              </div>
              <span className={styles.itemName}>{item.name}</span>
            </button>
          ))}
        </div>
      </div>
    </div>
  )
}