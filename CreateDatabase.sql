-- =============================================================
-- Skills International — Student Registration System
-- MySQL version
-- Run this script in MySQL Workbench or the MySQL command line:
--   mysql -u root -p < CreateDatabase.sql
-- =============================================================

-- 1. Create and select the database
CREATE DATABASE IF NOT EXISTS student;
USE student;

-- =============================================================
-- 2. Registration table
-- =============================================================
CREATE TABLE IF NOT EXISTS Registration (
    regNo       INT             NOT NULL PRIMARY KEY,
    firstName   VARCHAR(50)     NOT NULL,
    lastName    VARCHAR(50)     NOT NULL,
    dateOfBirth DATETIME        NOT NULL,
    gender      VARCHAR(10)     NOT NULL,
    address     VARCHAR(200)    NOT NULL,
    email       VARCHAR(100)    NOT NULL,
    mobilePhone VARCHAR(20)     NOT NULL,
    homePhone   VARCHAR(20)     NULL,
    parentName  VARCHAR(50)     NOT NULL,
    nic         VARCHAR(50)     NOT NULL,
    contactNo   VARCHAR(20)     NOT NULL
);

-- =============================================================
-- 3. Logins table  (optional — for DB-based authentication)
-- =============================================================
CREATE TABLE IF NOT EXISTS Logins (
    username    VARCHAR(50)     NOT NULL PRIMARY KEY,
    password    VARCHAR(50)     NOT NULL
);

-- Seed the default admin account
INSERT IGNORE INTO Logins (username, password) VALUES ('Admin', 'Skills@123');

SELECT 'Setup complete. You may now run the application.' AS Status;
