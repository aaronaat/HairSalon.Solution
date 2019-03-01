# HairSalon.Solution
---
### Epicodus Friday Project March 1st, 2019
## by Aaron Taylor
---
### Description
Hair salon manager

User can view and add stylists and stylist's clientscd c

Behavior | Input | Output
--- | --- | ---
user adds stylist | stylist name | stylist saved in database
user adds stylist client | client name | client saved in database
---
### Setup
```
git clone https://github.com/aaronaat/HairSalon.Solution.git
```

* Instructions to recreate database in MySQL prompt
```
CREATE DATABASE aaron_taylor;
USE aaron_taylor;
CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255))
CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT)
```

### Known Bugs
None

### Support and contact details
aarontaylor@gmail.com

### Technologies Used
C#, .NET, HTML, Razor, MySQL

### License
MIT
