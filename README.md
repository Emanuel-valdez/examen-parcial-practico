# Segundo parcial 2 Sistema de Gestión de Inventario

Aplicación de consola desarrollada en **C#** para representar productos de una tienda, clasificados en electrónicos y alimentos, con cálculo de impuestos según el tipo.

---

## Estructura del Proyecto

```
SistemaInventario/
└── Program.cs
```

## Clases

| Clase | Descripción |
|---|---|
| `Producto` | Clase base con atributos comunes (nombre, código, precio, cantidad) |
| `ProductoElectronico` | Hereda de Producto. Agrega garantía en meses. Impuesto: 18% |
| `ProductoAlimento` | Hereda de Producto. Agrega fecha de vencimiento. Impuesto: 8% |

---


## Salida en Consola

```
===== PRODUCTO ELECTRONICO =====
Producto: Laptop
Codigo: P1001
Precio: 45000
Cantidad: 5
Garantia: 12 meses
Impuesto: 8100

===== PRODUCTO ALIMENTO =====
Producto: Arroz
Codigo: A2001
Precio: 350
Cantidad: 100
Fecha de Vencimiento: 2025-12-31
Impuesto: 28
```

---

## Información Académica

| Campo | Detalle |
|---|---|
| **Universidad** | Universidad Central del Este (UCE) |
| **Asignatura** | Programación Básica |
| **Profesor** | Ing. Gamalier Reyes del Carmen |
| **Estudiante** | _(Emanuel valdez)_ |
| **Matrícula** | _(2024-0820)_ |
