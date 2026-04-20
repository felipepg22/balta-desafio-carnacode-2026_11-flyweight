![ES-6](https://github.com/user-attachments/assets/f45a9cd1-e873-4945-b771-caacc98d7a11)

## 🥁 CarnaCode 2026 - Challenge 11 - Flyweight

Hi, I'm Felipe Parizzi Galli, and this is where I share my learning journey during the **CarnaCode 2026** challenge by [balta.io](https://balta.io). 👻

Here you will find projects, exercises, and code that I am building throughout the challenge. The goal is to get hands-on, test ideas, and track my progress in tech.

### About this challenge
In the **Flyweight** challenge, I had to solve a real-world problem by implementing this **Design Pattern**.

During this process, I learned:
* ✅ Software Best Practices
* ✅ Clean Code
* ✅ SOLID
* ✅ Design Patterns

## Problem
A text editor needs to render millions of characters, each with formatting properties (font, size, color, and style). Creating one object per character consumes too much memory and degrades performance.

## About CarnaCode 2026
The **CarnaCode 2026** challenge consists of implementing all 23 Design Patterns in real-world scenarios. Across these 23 challenges, participants practice identifying non-scalable code and solving problems with widely used design patterns.

### eBook - Design Pattern Fundamentals
My main learning resource during this challenge was the free eBook [Design Pattern Fundamentals](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Check my challenge progress
[Add link to the central repository]

## What was implemented to apply the Flyweight pattern
To implement Flyweight in this project, the following was done:

* A shared flyweight contract was created with `ICharacter`, defining behavior for rendering and memory estimation.
* The `Character` class was implemented as the concrete flyweight, storing only intrinsic (shared) formatting state: font family, font size, color, and style flags.
* The `CharacterFactory` was created to manage a pool (`Dictionary<string, ICharacter>`) and reuse existing flyweights based on a composite key of formatting properties.
* In `Program` (`Challenge.cs`), repeated character formatting requests now go through the factory, ensuring equal formatting reuses the same object instead of creating duplicates.
* Extrinsic state (symbol, row, and column) is passed at render time via `Render(char symbol, int row, int column)`, keeping per-character data outside shared objects.
* Memory usage reporting was added in the factory (`GetMemoryUsage`) to show the reduction achieved by object sharing.

## Memory usage report
Memory usage was measured before and after the Flyweight implementation:

* Baseline (`5855922`): **3,321 bytes** (`Approximate memory: 3,321 bytes`)
* Current (`main`): **162 bytes** (`Memory used: 162 bytes`)
* Absolute reduction: **3,159 bytes**
* Relative reduction: **95.12%**

Detailed results are also available in `MEMORY_USAGE_REPORT.md`.
