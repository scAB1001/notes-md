# Goal:
# Outline:
## 14. Fault Tolerance - *Chapter 8*
presenting the basic concepts related to processing
failures, followed by a discussion of failure models. The key technique for
handling failures is redundancy.
### Dependability, reliability and availability in a DS
Being fault tolerant is strongly related to what are called dependable systems.
Requirements for a **dependable** system: *Availability*, *Reliability*, *Safety* and *Maintainability*.

**(Availability)** is defined as the property that a system is ready to be used immediately. In general, it refers to the probability that the system is operating correctly at any given moment and is available to perform its functions on behalf of its users. In other words, a highly available system is one that will most likely be working at a given instant in time.

The **availability** $A(t)$ of **a component** in the time interval $[0, t]$ is the *average fraction of time* that the component has been *functioning correctly* during that interval. 
The **long-term availability** $A$ of a component is defined as $A(∞)$.
Likewise, the **reliability** $R(t)$ of a component in the time interval $[0, t]$ is the *conditional probability* that it has been *functioning correctly* during that interval *given* that it was *functioning correctly* at time $T = 0$.
- **Mean Time To Failure** ($MTTF$): The average time until a component fails
- **Mean Time To Repair** ($MTTR$): The average time needed to repair a component
- **Mean Time Between Failures** ($MTBF$) = $MTTF + MTTR$
- General Availability: $A ={ MTTF \over MTBF} = {MTTF \over{MTTF + MTTR}}$

**(Reliability)** refers to the property that a system can run continuously without failure. *In contrast to availability*, reliability is defined in terms of a time interval instead of an instant in time. A highly reliable system is one that will most likely continue to work without interruption during a relatively long period of time. This is a subtle but *important difference* when compared to availability. If a system goes down on average for one, seemingly random millisecond every hour, it has an availability of more than 99.9999 percent, but is still unreliable. Similarly, a system that never crashes but is shut down for two specific weeks every August has high reliability but only 96 percent availability. The two differ.

**(NOTE)** Reliability and availability make sense only if we have an accurate notion of what a *failure* actually is.

**(Safety)** refers to the situation that when a system temporarily fails to operate correctly, no catastrophic event happens. For example, many process-control systems, such as those used for controlling nuclear power plants or sending people into space, are required to provide a high degree of safety. If such control systems temporarily fail for only a very brief moment, the effects could be disastrous. Many examples from the past (and probably many more yet to come) show how hard it is to build safe systems.

**(Maintainability)** refers to how easily a failed system can be re- paired. A highly maintainable system may also show a high degree of availability, especially if failures can be detected and repaired automatically. Automatic failure recovery difficult.
### Terminology
A system is said to *fail* when it cannot meet its promises. In particular, if a distributed system is designed to provide its users with a number of services, the system has failed when one or more of those services cannot be (completely) provided.

| Term              | Description                                           | Example |
| ----------------- | ----------------------------------------------------- | ------- |
| Failure           | A component is not living up to its<br>specifications |         |
| Error             | Part of a component that can<br>lead to a failure     |         |
| Fault             |                                                       |         |
| Fault Prevention  |                                                       |         |
| Fault Tolerance   |                                                       |         |
| Fault Forecasting |                                                       |         |

### Failure models
### Process resilience
### Consensus with crash failures
### Consensus with arbitrary failures
### The Byzantine Generals Problem
# Content: