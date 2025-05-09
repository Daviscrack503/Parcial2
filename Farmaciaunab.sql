CREATE DATABASE FarmciaUnab;
GO


CREATE TABLE Medicamentos (
    Id INT PRIMARY,
    NombreMedicamento VARCHAR(100) NOT NULL,
    PrecioMedicamento DECIMAL(10,2) NOT NULL
);
GO
INSERT INTO Medicamentos (NombreMedicamento, PrecioMedicamento) 
VALUES 
('Paracetamol', 5.99),
('Ibuprofeno', 8.50),
('Amoxicilina', 12.75);
GO
