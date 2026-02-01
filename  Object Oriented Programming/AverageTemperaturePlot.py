import pandas as pd
import matplotlib.pyplot as plt

# Fahrenheit to Celsius conversion
def fahrenheit_to_celsius(f):
    return round((f - 32) * 5 / 9, 1)

# Read temperature data from the web
data = pd.read_csv(
    "https://raw.githubusercontent.com/andrzejmp/some_codes/refs/heads/main/python/temperatures/data.csv"
)

# Select max and min temperatures
tmax = data["TMAX"]
tmin = data["TMIN"]

# Convert to Celsius
tmax_c = [fahrenheit_to_celsius(t) for t in tmax]
tmin_c = [fahrenheit_to_celsius(t) for t in tmin]

# Calculate average daily temperature
avg_temp = [(tmax_c[i] + tmin_c[i]) / 2 for i in range(len(tmax_c))]

# Plot
plt.style.use("seaborn-v0_8")
plt.figure(figsize=(10, 5))
plt.plot(avg_temp)
plt.title("Average Daily Temperature in Death Valley (2018)")
plt.xlabel("Days")
plt.ylabel("Temperature (°C)")
plt.show()