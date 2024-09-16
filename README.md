# User Management Application

This application is designed to manage a list of users. It allows users to add, edit, and delete user details, which are displayed in a `DataGridView` format. The application includes fields for storing the user's basic information like name, ID, email, and other personal details.

## Features

- **Data Entry Fields**:
  - Name
  - ID
  - Email
  - Age
  - Phone
  - Blood Group
  
- **DataGridView**:
  - Displays the list of all users.
  - Displays the added users in a grid format with each user's details.
  
- **Functionality**:
  - `Save`: Saves the entered user data to the DataGridView.
  - `Edit`: Allows the user to select a row from the DataGridView, update the details, and save changes.
  - `Delete`: Deletes the selected user from the DataGridView.

## Components

### 1. Input Fields:
- **Name**: Textbox for the user's full name.
- **ID**: Textbox for a unique user identification number.
- **Email**: Textbox for the user's email address.
- **Age**: Numeric input for the user's age.
- **Phone**: Textbox for the user's phone number.
- **Blood Group**: Drop-down list to select the blood group.

### 2. DataGridView:
A grid that lists all users with the following columns:
- ID
- Name
- Email
- Age
- Phone
- Blood Group

### 3. Buttons:
- **Save**: Adds the new user's data to the DataGridView.
- **Edit**: Edits the selected user's details.
- **Delete**: Deletes the selected user from the grid.

## Usage

1. **Adding a User**:
   - Fill out all the input fields with the user details.
   - Click the `Save` button to add the user to the list.
   
2. **Editing a User**:
   - Select a user from the DataGridView.
   - Update the input fields with the new details.
   - Click the `Edit` button to save changes.

3. **Deleting a User**:
   - Select a user from the DataGridView.
   - Click the `Delete` button to remove the user from the list.

## Example GUI Layout
![Screenshot 2024-09-16 193006](https://github.com/user-attachments/assets/272388bf-4c3e-4f0e-94dd-e27255fbcb76)

## Technologies Used

- .NET Framework (for Windows Forms or WPF)
- C# Programming Language (for back-end logic)
- DataGridView Control (for displaying data)

## Installation and Setup

1. Clone the repository.
2. Open the project in Visual Studio.
3. Build and run the project.
