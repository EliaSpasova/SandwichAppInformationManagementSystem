# SandwichAppInformationManagementSystem
This comprehensive application facilitates the management of a sandwich menu for restaurants or cafes, offering dual functionality for both employees and customers. It allows for the addition and updating of sandwich details, order management, and the viewing of sandwich information.

## Features

- **Dual Functionality:** Designed for use by both **employees** for management tasks and **customers** for browsing the menu and placing orders.
- **Dynamic Sandwich Management:** Employees can **add**, **insert** and **update** sandwiches, manage their characteristics, and handle customer orders efficiently.
- **Visual Menu:** Supports uploading and displaying images for each sandwich, enhancing the customer's menu browsing experience.
- **Order Processing:** Simplifies the ordering process, including dine-in and takeaway options, summing the total check of the order, improving operational efficiency.

## Installation

1. Clone the repository to your local machine.
2. Ensure SQL Server is installed and operational.
3. Open the project in Visual Studio.
4. Build and run the application to get started.

## Application Workflow and Challenges

### WinForms Overview

- **Login Form:** Manages user authentication, differentiating access between employees and customers.
- **Cart:** Manages what each customer wants to order, calculates the sum of the sandwiches.
- **Menu Form:** Displays the available sandwiches, allowing customers to view details and place orders.
- **Sandwich Info:** Displays the sandwiches' information (calories, allergens, image)
- **Add Sandwich Form:** Enables employees to input new sandwiches into the system, capturing details such as ingredients, prices, and images.
- **Order Form:** Facilitates the ordering process for customers, including selection between dine-in and takeaway options.
- **Admin Window:** enables employees to open other forms, such as Insert a new Sandwich, Update it and view all orders
- **Insert Form:** helps employees add new sandwiches and their information/properties to the database.
- **Update Sandwich Form:** Allows employees to edit the details of existing sandwiches, ensuring the menu stays up-to-date, such as price, amount and all other attributes of the sandwich.
- **All orders:** gives access to employees to view all orders from the application, instead of the SQL database
- ## Classes
  - *authenticate* - helps keep track and save all of the current user's information
  - *currentSandwich* - helps keep track and save all of the current sandwich's information

### Challenges and Solutions

- **Singleton Pattern for User Session:** Ensured consistent user context across forms, allowing seamless operation between customer and employee functionalities.
- **Image Handling:** Integrated image upload and conversion functionality to enhance the menu's visual appeal for customers.
- **Data Integrity Across Multiple Tables:** Implemented transactional operations for updating sandwich details, maintaining consistency and integrity.
- **UI/UX Design:** Focused on creating an appealing and functional interface, recommending a starting window size of 800x600 pixels, adjustable based on content needs and user feedback.

## Conclusion

The Sandwich App Information Management System stands as a versatile platform that streamlines the sandwich ordering and management process. Through careful design and problem-solving, this application serves the needs of both employees and customers, providing a robust and user-friendly tool for enhancing the dining experience.
