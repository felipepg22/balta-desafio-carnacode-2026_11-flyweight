# Memory Usage Report - Flyweight Challenge

## Context
This report compares memory usage before and after the Flyweight implementation.

## Execution Details
- Historical commit checked out: `5855922`
- Current branch checked out after test: `main`
- No commit or push performed for this report.

## Results

### 1) Baseline (before Flyweight)
- Reference: commit `5855922`
- Command used: `dotnet run src/Challenge.cs`
- Output line:
  - `Memoria aproximada: 3.321 bytes (3,24 KB)`
- Recorded memory usage: **3,321 bytes**

### 2) Current implementation (Flyweight)
- Reference: branch `main`
- Command used: `dotnet run --project DesignPatternChallenge/DesignPatternChallenge.csproj`
- Output line:
  - `Memoria usada: 162`
- Recorded memory usage: **162 bytes**

## Comparison
- Absolute reduction: `3,321 - 162 = 3,159 bytes`
- Relative reduction: `(3,159 / 3,321) * 100 = 95.12%`

## Conclusion
For the simulated scenario in this project, the Flyweight-based version reduced memory usage from **3,321 bytes** to **162 bytes**, a **95.12%** reduction.
