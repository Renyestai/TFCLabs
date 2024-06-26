# Компилятор

Разработка текстового редактора с функциями языкового процессора.

## Оглавление
- [Лабораторная работа №5: Включение семантики в анализатор. Создание внутренней формы представления программы](#лабораторная-работа-5-включение-семантики-в-анализатор-создание-внутренней-формы-представления-программы)

- [Лабораторная работа №6: Реализация алгоритма поиска подстрок с помощью регулярных выражений](#лабораторная-работа-6-реализация-алгоритма-поиска-подстрок-с-помощью-регулярных-выражений)

- [Лабораторная работа №7: Реализация метода рекурсивного спуска для синтаксического анализа](#лабораторная-работа-7-реализация-метода-рекурсивного-спуска-для-синтаксического-анализа)

## Лабораторная работа №5: Включение семантики в анализатор. Создание внутренней формы представления программы

**Тема:** включение семантики в анализатор, создание внутренней формы представления программы. 

**Цель работы:** дополнить анализатор, разработанный в рамках лабораторных работ, этапом формирования внутренней формы представления программы. Дополнить грамматику, разрабатываемую в рамках курсовой работы, продукциями из грамматики G[<АВ>]. Реализовать парсер для дополненной грамматики.

### Тестовые примеры

1. **Тест №1.** 
   
   ![Тест 1](/README_images/postfix_test_1.png)
2. **Тест №2.** Обработка пропущенной скобки.

   ![Тест 2](/README_images/postfix_test_2.png)
3. **Тест №3.** Обработка пропущенных переменных.

   ![Тест 3](/README_images/postfix_test_3.png)

## Лабораторная работа №6: Реализация алгоритма поиска подстрок с помощью регулярных выражений

**Тема:** реализация алгоритма поиска подстрок с помощью регулярных выражений.

**Цель работы:** реализовать алгоритм поиска в тексте подстрок, соответствующих заданным регулярным выражениям.

## Задачи

1. (I.6) Построить РВ, описывающее шестнадцатеричный код (HEX) цвета (длиной 6).

```
#[0-9A-Fa-f]{6}
```

![Тест](/README_images/reg_test_1.png)

2. (II.12) Построить РВ для проверки ISBN-10.

```
\b(?:\d[\s-]*){9}[\dX]\b
```

![Тест](/README_images/reg_test_2.png)

3. (III.19) Построить РВ, описывающее XML тег.

```
<(?:[a-zA-Z0-9_-]+\s*(?:[a-zA-Z0-9_-]+= ""[^""]*""\s*)*|/[a-zA-Z0-9_-]+)>
```

![Тест](/README_images/reg_test_3.png)


## Лабораторная работа №7: Реализация метода рекурсивного спуска для синтаксического анализа

**Тема:** реализация метода рекурсивного спуска для синтаксического анализа.

**Цель работы:** разработать для грамматики алгоритм синтаксического анализа на основе метода рекурсивного спуска.

Для грамматики G[stmt] разработать и реализовать алгоритм анализа на основе метода рекурсивного спуска.
                
    G[stmt]:
    1. stmt → IF exp stmt | IF exp stmt ELSE stmt | ID ASSIGN exp SEMICOLON
    2. exp -> TRUE | FALSE | exp OR exp | exp AND exp | NOT exp | exp


> Примечание: ID – переменная Б{Б|Ц}, Б – {a, b, c, ...z, A, B, …, Z}, Ц – {0, 1, …, 9}, ASSIGN – ”==” | ”<” | ”<=” | ”>” | ”>=” | ”!=”

По классификации Хомского данная грамматика относится к КС. 

### Тестовые примеры

Первый тест

![Тест 1](/README_images/recursion_test_1.png)

Второй тест

![Тест 2](/README_images/recursion_test_22.png)

Третий тест

![Тест 3](/README_images/recursion_test_3.png)