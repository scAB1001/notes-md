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

| Term                               | Description                                                              | Example                                              |
| ---------------------------------- | ------------------------------------------------------------------------ | ---------------------------------------------------- |
| Failure                            | A component is not living up to its<br>specifications.                   | Program crashes.                                     |
| Error                              | Part of a component (system's state) that can lead to a failure.         | Programming Bug.                                     |
| Fault                              | The cause of an error.                                                   | The developer.                                       |
| Fault Prevention                   | Prevent the occurrence of a fault.                                       | Thorough software verification and validation.       |
| Fault Tolerance<br>(**Important**) | Build a component such that it can mask the occurrence of a fault.       | Build each component by two independent programmers. |
| Fault Removal                      | Reduce the presence, number, or seriousness of a fault.                  | Thorough software verification<br>and validation.    |
| Fault Forecasting                  | Estimate current presence, future incidence, and consequences of faults. | Check code quality /<br>programming experience.      |
The developer is the *fault* for the *error*: bug which caused the program to crash in *failure*.
The aim is to improve *fault tolerance* so that the system can provide its services even in the case of faults.
### Failure models

| Type of Failure                           | Description of Server’s Behaviour                                                                                   |
| ----------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| Crash                                     | Halts, but is working correctly until it halts                                                                      |
| Omission:<br> Receive<br> Send            | Fails to respond to incoming requests<br>Fails to receive incoming messages<br>Fails to send messages (response)    |
| Timing                                    | Response lies outside a specified time interval                                                                     |
| Performance                               | Server responds too late.                                                                                           |
| Response<br> Value<br> State-transition   | Response is incorrect<br>The value of the response is wrong<br>Deviates from correct flow of control (reacts wrong) |
| Arbitrary (or Byzantine)<br>**(Serious)** | May produce arbitrary responses at arbitrary<br>times that is not detected as incorrect. False info.                |
#### Dependability vs Security (Omission versus commission)
Arbitrary failures are sometimes qualified as malicious. It is important to make the following distinction:
• Omission failures: a component fails to take an action that it should have taken
• Commission failure: a component takes an action that it should not have taken
• Deliberate failures, be they omission or commission failures
are typically security problems. Distinguishing between
deliberate failures and unintentional ones is, in general, very
hard.
#### Failure Masking by Redundancy
Types of Redundancy
• Information redundancy: Add extra bits to data units so that
errors can be recovered when bits are garbled
• E.g. Hamming code
• Time redundancy: Design a system such that an action can be
performed again if anything went wrong
• E.g. retransmission request to a server when lacking an expected
response
• Physical redundancy: add equipment or processes in order to
allow one or more components to fail. This type is extensively
used in distributed systems
• E.g. extra processes are added to a system so that if a number of
processes crash, the system can still function correctly.
### Process resilience
### Consensus with crash failures
### Consensus with arbitrary failures
### The Byzantine Generals Problem
# Content: