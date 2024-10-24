# Finacify.App

## Overview
This project is a budgeting application aimed at helping users manage their personal finances by tracking income and expenses. The app allows users to categorize their transactions, set budget limits, and view summaries of their financial activities. The primary technologies used in this project include **C#**, **Windows Forms** for the graphical user interface (GUI), and **Excel** files for data storage.

## Architecture
The application follows a modular architecture where the core logic is divided into different classes for ease of maintenance and scalability.

- **Frontend Framework**: Windows Forms is used for the user interface, providing a responsive and user-friendly experience.
- **Backend**: The backend logic, responsible for managing the user's income and expenses, is built in C#. Classes such as `Budget`, `Income`, and `Expense` handle the core financial calculations.
- **Data Storage**: Data is temporarily stored in Excel files, allowing users to load and save their financial data without a database. This was chosen for simplicity in the early stages of development, though a database integration is planned for future iterations.

### Architectural Decisions
- **NoSQL vs SQL**: For simplicity, we opted for Excel file storage instead of a more complex database system like SQL or NoSQL. This decision was made to minimize dependencies and reduce setup time for users.
- **Cloud vs On-premise**: This is an on-premise solution because all data is stored locally on the user's device. A potential cloud integration could be added in the future for backups or synchronization across multiple devices.

## Functionality
The project has several key features, each communicating with others to ensure seamless functionality:
- **Forms**: Different forms in the application allow users to add, delete, and view income or expense transactions. They are connected through event handling.
- **Data Exchange**: Data is exchanged between forms and the back-end classes in the form of C# objects and stored in Excel files.
  
#### Refactoring Example
Initially, the income and expense management were handled directly in the `Forms` class. However, this resulted in tightly coupled code, making future changes harder. To improve maintainability and scalability, I refactored the code by moving the logic into dedicated `Income` and `Expense` classes. This made the code more modular and significantly reduced duplication. As a result, adding new features like editing a transaction became much easier.

## Testing
For testing, I used manual and automated approaches:
- **Unit Tests**: Key classes such as `Budget`, `Income`, and `Expense` were tested with various scenarios to ensure correctness in financial calculations.
- **Integration Tests**: The interaction between different forms and the backend logic was tested manually, focusing on the correct exchange of data and user interaction.
  
### Testing Challenges
One challenge I encountered was ensuring data integrity during import/export from Excel files. Since Excel doesn't enforce strict data types, I had to add additional validation logic to handle unexpected values.

## Reflection
Working on this project helped me deepen my understanding of **C#**, **Windows Forms**, and handling data storage with Excel. It also reinforced the importance of modularizing code for maintainability, which has been a key professional goal as I prepare for roles in software engineering. By refactoring the core logic, I have improved both my problem-solving skills and my approach to software design.

### Personal Takeaways
This project taught me the importance of refactoring early to avoid technical debt and improved my ability to manage data efficiently. In future projects, I plan to apply similar principles and also explore more scalable storage options like SQL databases or cloud services.
