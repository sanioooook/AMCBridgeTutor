# CAR WASH
### **Description**

Develop a cost management program for a car wash. The car wash offers three types of washes:

* Body
* Glass
* Detailing

This car wash can serve three types of vehicles with the following price offers:

| -         | Truck |  Car  | Motorcycle |
| :-------- | :---: | :---: | ---------: |
| Body      |  $20  |  $7   |         $5 |
| Glass     |  $10  |  $2   |          - |
| Detailing |  $15  |  $5   |          - |

### **Input:**

1. An array of four-digit integers, where each number represents a vehicle in the line, and each digit in the number specifies required services for the vehicle:
   1. Vehicle type: truck (1), car (2), or motorcycle (3).
   2. Body wash if its value is not zero.
   3. Glass wash if its value is not zero.
   4. Detailing if its value is not zero.
2. Termination number -1.

**Note:** Glass and Detailing services are not provided for motorcycles; a motorcycle should not be charged for these services regardless the values of the third and the fourth digits in the corresponding four-digit integer.

### **Output:**
1. Total cost for all vehicles.
2. An array of integers, where each number is the price for a vehicle; their order corresponds to the vehicle order in the input array.
3. Termination number -1.

Project code: CarWash

### **Examples:**
Input:

`1100 2010 3101 2111 -1`

Output:

`41 20 2 5 14 -1`

### **Calculations:**

| Vehicle wash order | Calculations |  Sum  |                Description                 |
| :----------------- | :----------: | :---: | :----------------------------------------: |
| **1100**           |  20 + 0 + 0  |  20   |              Truck body wash               |
| **2010**           |  0 + 2 + 0   |   2   |               Car glass wash               |
| **3101**           |      5       |   5   | Motorcycle body wash, detailing is ignored |
| **2111**           |  7 + 2 + 5   |  14   |              Car all included              |

Total = 20 + 2 + 5 + 14 = 41

Output: 41 20 2 5 14 -1


