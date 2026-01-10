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

| Term                                    | Description                                                              | Example                                              |
| --------------------------------------- | ------------------------------------------------------------------------ | ---------------------------------------------------- |
| Failure                                 | A component is not living up to its<br>specifications.                   | Program crashes.                                     |
| Error                                   | Part of a component (system's state) that can lead to a failure.         | Programming Bug.                                     |
| Fault                                   | The cause of an error.                                                   | The developer.                                       |
| Fault Prevention                        | Prevent the occurrence of a fault.                                       | Thorough software verification and validation.       |
| Fault Tolerance (FT)<br>(**Important**) | Build a component such that it can mask the occurrence of a fault.       | Build each component by two independent programmers. |
| Fault Removal                           | Reduce the presence, number, or seriousness of a fault.                  | Thorough software verification<br>and validation.    |
| Fault Forecasting                       | Estimate current presence, future incidence, and consequences of faults. | Check code quality /<br>programming experience.      |
The developer is the *fault* for the *error*: bug which caused the program to crash in *failure*.
Aim: improve *fault tolerance* -> system can provide its services *even* in the case of faults.
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
- *Omission* failures: a component *fails to take an action* that it *should have* taken
- *Commission* failure: a component *takes an action* that it *should not have* taken
These deliberate failures are often *security* problems. Distinguishing between *deliberate* failures and *unintentional* ones is difficult.
#### Failure Masking by Redundancy
If a system is to be fault tolerant, the best it can do is to try to hide the occurrence of failures from other processes. The key technique for masking faults is to use redundancy:
- **Information** redundancy: Add extra bits to data units so that errors can be recovered when bits are garbled e.g., Hamming code
- **Time** redundancy: Design a system where actions can be performed again if anything went wrong e.g., retransmission request to a server when lacking an expected response
- **Physical** redundancy: add equipment or processes in order to allow one or more components to fail. Often used in DS e.g., extra processes are added to a system so that the system can still function correctly if processes crash.
### Process resilience by Groups
FT can actually be achieved in DS by *protecting* against *process failures*, which is achieved by **replicating processes** into groups. 

organize several identical processes into a group. The key property that all groups have is that when a message is sent to the group itself, all members of the group receive it. In this way, if one process in a group fails, hopefully some other process can take over for it.

Process groups may be dynamic. New groups can be created and old
groups can be destroyed. A process can join a group or leave one during
system operation. A process can be a member of several groups at the same
time. Consequently, mechanisms are needed for managing groups and group
membership.
#### Groups Organisation
An important distinction between different groups has to do with their internal structure. In some groups, all processes are equal. There is no distinctive leader and all decisions are made collectively. In other groups, some kind of hierarchy exists. 
![[process-groups.png]]
**(FLAT GROUP)** symmetrical and has no single point of failure. If one of
the processes crashes, the group simply becomes smaller, but can otherwise
continue. A disadvantage is that decision making is more complicated. For
example, to decide anything, a vote often has to be taken, incurring some
delay and overhead.
**(HIERARCHICAL GROUP)** has the opposite properties. Loss of the coordinator
brings the entire group to a grinding halt, but as long as it is running, it
can make decisions without bothering everyone else. In practice, when the
coordinator in a hierarchical group fails, its role will need to be taken over and
one of the workers is elected as new coordinator.
#### Groups and Failure Masking
A **k-fault tolerant group**: when a group can mask any $k$ concurrent member failures. 
A system is said to be **k-fault tolerant** if it can survive faults in $k$ components and still meet its specifications. $k$ is called **degree of fault tolerance**.

If the components, say processes, fail silently, then having $k + 1$ of them is enough to provide k-fault tolerance. If $k$ of them simply stop, then use the answer from the other one.
With **halting failures** (crash/omission/timing failures): we need a total of **k +1** members as no member will produce an incorrect result, so the result of one member is good enough.

On the other hand, if processes exhibit **arbitrary failures**, continuing to run when faulty and sending out erroneous or random replies, a minimum of $2k + 1$ processes are needed to achieve k-fault tolerance. In the worst case, the $k$ failing processes could accidentally (or even intentionally) generate the same reply. However, the remaining $k + 1$ will also produce the same answer, so the client or voter can just believe the majority.
### Consensus with crash failures
In terms of clients and servers, we have adopted a model in which a potentially very large collection of clients now send commands to a group of processes that jointly behave as a single, highly robust process. To make this work, we need to make an important assumption:

In a **fault-tolerant process group**, each nonfaulty process executes the same commands, in the same order, as every other nonfaulty process

Group members must reach consensus on which command to execute. If failures cannot happen, reaching consensus is easy. For example, using a centralized sequencer that hands out a sequence number to each command that needs to be executed.
#### Crash Failures: Flooding-based Consensus
Assume we have a group of processes P = {P1, . . . , Pn} operating under **fail-stop** failure semantics. We assume that crash failures can be reliably detected among the group members (reliable failure detection). 
A client contacts a group member requesting it to execute a command. Every group member maintains a list of proposed commands: some which it received directly from clients; others which it received from its fellow group members.

The algorithm operates in rounds. In each round, a process $P_i$ sends its list of proposed commands it has seen so far to every other process in $P$. At the end of a round, each process merges all received proposed commands into a new list, from which it then will deterministically select the command to execute, if possible. 

It is important to realize that the selection
algorithm is the same for all processes. In other words, if all process have
exactly the same list, they will all select the same command to execute (and
remove that command from their list).
It is not difficult to see that this approach works as long as processes do
not fail. Problems start when a process Pi detects, during round r, that, say
process Pk has crashed. To make this concrete, assume we have a process
### Consensus with arbitrary failures
### The Byzantine Generals Problem
# Content: