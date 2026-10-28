# Resultados de las pruebas — GeoLab 2D

- **Fecha de ejecución:** 2026-10-25
- **Origen:** `GeometryTests.RunAll()` de `GeoLab2D/Tests/GeometryTests.cs`, ejecutado sobre `bin/Debug/GeoLab2D.exe`
  (el mismo código que corre el botón **Pruebas → Ejecutar pruebas** de la aplicación).
- **Resultado:** **18 de 18 pruebas aprobadas**, 0 fallidas.

| Prueba | Entradas | Esperado | Obtenido | Tolerancia | Estado |
|---|---|---|---|---|---|
| 1. Magnitud vectorial | A = (3, 4) | \|A\| = 5 | \|A\| = 5 | 0.000001 | Aprobado |
| 2. Producto punto | A = (1, 2), B = (3, 4) | 11 | 11 | 0.000001 | Aprobado |
| 3. Determinante | A = (1, 0), B = (0, 1) | 1 | 1 | 0.000001 | Aprobado |
| 4. Distancia | A = (0, 0), B = (3, 4) | 5 | 5 | 0.000001 | Aprobado |
| 5. Área del hexágono | L = 2 | P = 12, A = 6√3 ≈ 10.3923 | P = 12.0000, A = 10.3923 | 0.000001 | Aprobado |
| 6. Área del pentágono | L = 2 | P = 10, A ≈ 6.8819 | P = 10.0000, A = 6.8819 | 0.000001 | Aprobado |
| 7. Traslación | P = (2, 3), T = (5, -1) | (7; 2) | (7; 2) | 0.000001 | Aprobado |
| 8. Rotación | P = (1, 0), θ = 90° | (0; 1) | (0; 1) | 0.000001 | Aprobado |
| 9. Escalamiento | P = (2, 3), sx = 2, sy = 3 | (4; 9) | (4; 9) | 0.000001 | Aprobado |
| 10. Proyección | A = (0, 0), B = (4, 0), P = (2, 3) | Q = (2; 0), d = 3 | Q = (2; 0), d = 3 | 0.000001 | Aprobado |
| 11. Pertenencia a un polígono | Cuadrado (0,0)-(4,4); P = (2,2), (5,2), (4,2) | Inside, Outside, OnBorder | Inside, Outside, OnBorder | 0.000001 | Aprobado |
| 12. Segmento degenerado | A = B = (1, 1), P = (4, 5) | Q = A, d = 5, sin división entre cero | Q = (1; 1), d = 5 | 0.000001 | Aprobado |
| 13. Estrella de 5 vértices | N = 5, K = 2 | 1 recorrido cerrado con los 5 vértices | 1 recorrido: 0→2→4→1→3→0 | 0.000001 | Aprobado |
| 14. Restauración | Hexágono, 60 transformaciones y Restaurar | Coordenadas originales | Coordenadas idénticas | 0.000001 | Aprobado |
| 15. Orientación | (0,0),(1,0),(0,1) \| (0,0),(0,1),(1,0) \| (0,0),(1,1),(2,2) | Antihoraria, Horaria, Colineales | Antihoraria, Horaria, Colineales | 0.000001 | Aprobado |
| 16. Estrella {6/2} | N = 6, K = 2 | 2 recorridos de 3 vértices | 2 recorridos | 0.000001 | Aprobado |
| 17. Margarita: solapamiento | L = 2; separación 1.0 y 0.8 | 1.0: no se solapan; 0.8: sí | 1.0: no; 0.8: sí | 0.000001 | Aprobado |
| 18. Dirección del vector nulo | V = (0, 0) | Error controlado (sin dirección) | Error controlado | 0.000001 | Aprobado |

