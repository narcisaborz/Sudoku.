  Verificator Sudoku in C#
Acest proiect implementează un verificator pentru grile Sudoku, asigurându-se că fiecare rând, coloană și sub-matrice 3x3 conțin numerele de la 1 la 9 fără repetiții.
  Caracteristici:
Primește o grilă Sudoku 9x9 ca input din consola.
Verifică validitatea Sudoku conform regulilor jocului.
Afișează True dacă Sudoku este valid și False dacă nu este.
  Formatul inputului
Programul așteaptă 9 linii de input, fiecare conținând 9 numere separate prin spațiu. Spațiile suplimentare între numere vor fi ignorate. Aceste numere trebuie să fie între 1 și 9.
Exemplu de input valid:
5 3 4   6 7 8   9 1 2
6 7 2   1 9 5   3 4 8
1 9 8   3 4 2   5 6 7

8 5 9   7 6 1   4 2 3
4 2 6   8 5 3   7 9 1
7 1 3   9 2 4   8 5 6

9 6 1   5 3 7   2 8 4
2 8 7   4 1 9   6 3 5
3 4 5   2 8 6   1 7 9

Dacă Sudoku este valid, output-ul va fi:
True
Dacă Sudoku nu este valid, output-ul va fi:
False
