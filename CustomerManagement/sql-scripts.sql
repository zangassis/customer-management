-- Create customer_db database
CREATE DATABASE IF NOT EXISTS customer_db;

-- Using customer_db database
USE customer_db;

-- Creste table customers
CREATE TABLE IF NOT EXISTS customers (
    id CHAR(36) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL
);

-- Create table addresses
CREATE TABLE IF NOT EXISTS addresses (
    id CHAR(36) PRIMARY KEY,
    street VARCHAR(100) NOT NULL,
    city VARCHAR(50) NOT NULL,
    state VARCHAR(50) NOT NULL,
    postalCode VARCHAR(20) NOT NULL,
    country VARCHAR(50) NOT NULL,
    customerId CHAR(36) NOT NULL,
    CONSTRAINT fk_addresses_customers FOREIGN KEY (customerId)
    REFERENCES customers(Id)
    ON DELETE CASCADE
);