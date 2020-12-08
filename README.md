# Pharmacy management

This is my team project for PRN292.

## Technical requires

- C# .NET Framework 4.7
- DevExpress for Winform v20.1
- Entity Framework 6.4
- MSSQL Server (others might not work properly)

## Features

### User role-based identity

The software provides a role-based identity for managing users. By default, there is one admin account with a password is "123@123a". Admin can create other roles, other users then grant role for them. Only role Admin can create new accounts, all others can only manage pharmacy commodity and their own information.

1. Login

   ![demo-img-0](./docs/demo-img-0.jpg)

2. Manage users

   <img src="./docs/demo-img-1.jpg" alt="demo-img-1" style="zoom:67%;" />

   <img src="./docs/demo-img-2.jpg" alt="demo-img-2" style="zoom:67%;" />

### Commodities and Invoices

1. New commodity (Medicine, tool, others.)

   <img src="./docs/demo-img-3.jpg" alt="demo-img-3" style="zoom:67%;" />

2. Manage all commodities (show, search, edit, remove, sort, etc.)

   <img src="./docs/demo-img-4.jpg" alt="demo-img-4" style="zoom:67%;" />

3. Invoicing

   <img src="./docs/demo-img-5.jpg" alt="demo-img-5" style="zoom:67%;" />

### Other features

1. Print report

   <img src="./docs/demo-img-6.jpg" alt="demo-img-6" style="zoom:67%;" />

2. Change theme

   <img src="./docs/demo-img-7.jpg" alt="demo-img-7" style="zoom:67%;" />