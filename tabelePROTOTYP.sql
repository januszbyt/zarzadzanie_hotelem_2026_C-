
USE HotelParadise;

CREATE TABLE Users (
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(150) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role ENUM('Recepcjonista', 'Administrator') NOT NULL
);

CREATE TABLE Rooms (
    RoomId INT AUTO_INCREMENT PRIMARY KEY,
    RoomNumber VARCHAR(10) NOT NULL UNIQUE,
    RoomType ENUM('Standard', 'Deluxe', 'Suite') NOT NULL,
    PricePerNight DECIMAL(10, 2) NOT NULL CHECK (PricePerNight >= 0),
    Status ENUM('Wolny', 'Zajęty') NOT NULL DEFAULT 'Wolny'
);

CREATE TABLE Guests (
    GuestId INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

CREATE TABLE Reservations (
    ReservationId INT AUTO_INCREMENT PRIMARY KEY,
    GuestId INT NOT NULL,
    RoomId INT NOT NULL,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalNights INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL CHECK (TotalAmount >= 0),
    Status ENUM('Aktywna', 'Zakończona', 'Anulowana') NOT NULL DEFAULT 'Aktywna',
    Notes TEXT,
    CONSTRAINT FK_Reservations_Guests FOREIGN KEY (GuestId) REFERENCES Guests(GuestId) ON DELETE CASCADE,
    CONSTRAINT FK_Reservations_Rooms FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId) ON DELETE CASCADE
);


INSERT INTO Users (FullName, Username, PasswordHash, Role) VALUES 
('Jan Kowalski', 'admin', 'hash_hasla_123', 'Administrator'),
('Anna Nowak', 'recepcja1', 'hash_hasla_456', 'Recepcjonista');

INSERT INTO Rooms (RoomNumber, RoomType, PricePerNight, Status) VALUES 
('101', 'Standard', 150.00, 'Wolny'),
('102', 'Standard', 150.00, 'Zajęty'),
('201', 'Deluxe', 300.00, 'Wolny'),
('301', 'Suite', 550.00, 'Wolny');

INSERT INTO Guests (FirstName, LastName, PhoneNumber, Email) VALUES 
('Piotr', 'Zieliński', '123456789', 'piotr.z@example.com'),
('Katarzyna', 'Wiśniewska', '987654321', 'kasia.w@example.com');

-- Dodanie rezerwacji (gość 1 w pokoju 102)
INSERT INTO Reservations (GuestId, RoomId, CheckInDate, CheckOutDate, TotalNights, TotalAmount, Status, Notes) VALUES 
(1, 2, '2023-11-01', '2023-11-05', 4, 600.00, 'Aktywna', 'Prośba o dodatkowe ręczniki');