## Final Checks
- [ ] Code 
	- [x] Consistent, sensible and descriptive naming
	- [ ] Removed unnecessary TO-DOs and Commented code
	- [ ] Commented clearly throughout
	- [x] Kept some additional sandbox tests
	- [ ] Compiles on SoC machine with no warnings
	- [x] All default tests pass
	- [ ] Include units on axes/reported numbers
- [ ] Document
	- [ ] Referenced algorithms, images, quotes etc.
	- [ ] ==FIX== backwards quote issue
	- [ ] ==FIX== code listing && as ^ issue
	- [x] 13 Pages only, 1 task per page + references.
	- [ ] Academic language, paragraphs, punctuation and spelling.
	- [ ] No code has been dumped.
	- [ ] All figures/listings have descriptive captions ==telling the reader what to pay attention to==
## Implementation
### 1.2 Clipping Lines (3 marks)
Consider the function `clip_line`. It is declared in *draw2d/draw.hpp* and defined in *draw2d/draw.cpp*.
It is supposed to take the line from `aBegin` to `aEnd` and clip it against the `aTargetArea` rectangle (`Rect2F`, defined in *draw2d/rect.hpp*).

If the line requires clipping, update the `aBegin` and `aEnd` arguments to define the clipped line (i.e., the portion of the line inside the target area). The arguments are defined as non-const references, meaning this will change the passed-in values. The function should return `true` if the line is visible and `false` otherwise. You should not make any dynamic allocations (nor any system calls) in the clipping method.

**In your report:** 
- [x] ==Explain== your method for clipping (as a reminder: do not just dump code into your report). Be concise. If appropriate, use a figure to support your explanation.
### 1.3 Drawing Lines (5 marks)
Next, consider the function `draw_line_solid` and the related `draw_clip_line_solid`. The functions are also declared in the *draw2d/draw.{hpp,cpp}* pair of files. The former is provided to you and simply calls `clip_line` and then -if visible- `draw_clip_line_solid`.

Implement the `draw_clip_line_solid` function. The goal is to produce a line that is as thin as possible (single pixel width) and that does not have any holes (i.e., each pixel should connect to another pixel either by nearest neighbours or by diagonals). Recall the parametrised version of a line as a starting point. You should ensure that the function produces correct results with all pre-clipped inputs. You may pick any drawing method, but it should scale with `O(N)`with respect to the number of drawn pixels`(N)`.

You should not make any dynamic allocations (nor any system calls) in the line drawing method.
The handed-out code contains two additional programs related to your line drawing. Use lines-sandbox
to visually verify your results in isolation. It includes a small number of examples already. You can switch
between the examples using the number keys. See source code comments for more information. You are free to add additional examples.

The second program, lines-test, runs a few automated tests on the line drawing. It uses the `Catch2`
testing library. Ensure that your implementation passes the existing tests. Refer to the source code for more information on the tests. With the line drawing in place, you should now be able to see a space ship (Figure 2a).

**In your report:** 
- [x] Explain your line drawing method. Be concise. Focus on technical aspects. Use equations/figu res for support. A reader should be able to understand how your method works.  
- [x] Include a screenshot of the drawn ship.
### 1.5 Drawing triangles (6 marks)
Consider the function `draw_triangle_interp`. It is also declared in the *draw2d/draw.hpp* header and defined in *draw2d/draw.cpp*. This function draws a single triangle defined by its three vertices (`aP0`, `aP1` and `aP2`). Each vertex is assigned a color (`aC0`, `aC1` and `aC2`, respectively). These colors should be interpolated across the triangle with barycentric interpolation. Implement this function. Make sure that the function works correctly with all (reasonable) inputs.

Unlike earlier examples, the colors are specified in linear RGB (`ColorF`). You should perform the interpolation in linear RGB space and only convert to the 8-bit sRGB representation when writing the color to the surface. 

You can pick any method, but it should be reasonably efficient (e.g., simply testing all pixels in the screen is not acceptable). You should not make any dynamic allocations or system calls in the triangle drawing method.

Use the `triangles-sandbox` to visually experiment with your triangle drawing in isolation. Run the tests in `triangles-test` and ensure that they pass. When you have implemented the triangle drawing, you should also be able to see the asteroids in the main program (see teaser image).

Note: You must not change the prototype of the `draw_triangle_interp` function. You must use `Surface▽ ▷ ::set_pixel_srgb` to draw pixels.

**In your report:** 
- [x] Explain your method (same requirements as Section 1.3). Document any ==special handing== that you perform. 
- [x] Include a screenshot of the main program, with the asteroids visible.
### 1.6 Blitting images (4 marks)
In this task, you will implement image blitting with alpha masking. Consider the `blit_masked` function
declared in *draw2d/image.hpp* and defined in draw2d/image.cpp. 

You will also need to implement a few helper functions in *draw2d/image.inl*. Search for lines containing the string // TODO. You should blit the input image (aImage of type `ImageRGBA`) to the position specified by `aPosition`. 

The position is relative to the center of the input image. Input pixels with an alpha value (a component of the `Color_sRGB_Alpha` color `struct`) less than 128 should be discarded. Consider efficiency in your implementation and do not make any dynamic allocations/syscalls (etc.). If you have implemented the method correctly, you should find the earth after flying a bit to the right – it will be off-screen initially (see teaser image and Figure 3).

Note: You must not change the prototype of the `blit_masked` function. You must not change the `ImageRGBA` class and the `load_image` function.

**In your report:** 
- [x] Describe your implementation of the blit (same requirements as Section 1.3). 
- [x] Discuss the efficiency of your implementation: Focus specifically on choices in your implementation that benefit efficiency and the ==impact of clipping/culling==.
### 1.7 Testing: lines (8 marks)
Consider the lines-test program. It contains a few example tests that verify expected behaviour. However, the tests are far from exhaustive. We will explore the following four scenarios to verify that the line drawing (with clipping) works correctly:
1. Consider lines with one point inside the surface and one outside.
2. Consider lines with both points outside of the surface.
3. Consider a line from p0 to p1. It should be identical to the line from p1 to p0.
4. Consider two lines. The first starts at p0 and extends to p1. The second starts at p1 and extends to p2.

When both are drawn, there should be no gap between the two lines. Extend this to multiple lines - what happens if the lines are very short?
First, for each scenario, construct four different cases that are distinct from each other in a significant way. Avoid selecting cases that share similar properties (e.g., where all are axis-aligned). Illustrate these using one figure per scenario, with the provided displayArea.{png,pdf,svg} as a base (see Figure 4). 

Next, implement tests for each scenario. Each scenario must be implemented in a separate TEST_CASE named ScenarioN (with N equal to the number in the list above) in the scenarios.cpp file. Each scenario is expected to (at least) test your representative lines. It is expected that each case uses multiple assertions. If your line drawing implementation fails some of the tests, you should tag the corresponding TEST_CASE with [!mayfail]. Mention this in your report.

**In your report:** 
- [x] Include the four figures with your selected cases (label individual cases if necessary). 
- [ ] ==Describe== them briefly and ==motivate your choice== of them: ==Why== are these are a good selection for your tests? 
- [x] Describe ==how== you have implemented the corresponding tests. No marks will be awarded for tests that lack an explanation and solid reasoning.
### 1.8 Testing: triangles (4 marks)
Add at least two (2) more distinct test cases to the triangles-test program. Refer to Section 1.7 for details – the same requirements/guidelines apply here. 

==2 SCENARIOS - 4 SECTIONS EACH==

Illustrate each of the two scenarios for your tests using Figure 4, showing triangles for each case. Use the provided *scenarios.cpp* file. Make sure the tests that you add are meaningful.

**In your report:** 
- [x] Describe each scenario. 
- [x] Include two figures with your representative cases for the scenarios (label individual cases if necessary). 
- [ ] ==Describe== them briefly and ==motivate your choice== of them: ==Why== are these are a good selection for your tests? 
- [ ] Describe ==how== you have implemented the corresponding tests. No marks will be awarded for tests that lack an explanation and solid reasoning.
### 1.9 Benchmarking - Specs (0 marks) - REQUIRED for Sections 1.10 to 1.12
This task by itself does not give you any marks, but is required if you plan on attempting the benchmarking related tasks. If the information is missing from your report (or obviously incorrect), the benchmarking tasks will automatically receive zero marks.

Important for all benchmarking tasks: You should only ever benchmark code built in the release configuration. The debug configuration disables many compiler optimizations (including code inlining!) to aid debugging and is therefore not representative of the final performance. Hence, when running benchmarks, make sure you only ever use release builds.

Modern CPUs and operating systems also adjust clock rates of the processor based on work load.
Many CPUs can additionally boost to higher clock rates for short periods of time. These features are
obviously desirable under normal conditions, but make life during benchmarking more difficult.
Refer to Benchmarking details below for additional discussion on this topic.
**In your report:** 
- [x] Please reproduce the following table in your report and fill in with the relevant information for the system on which you run the benchmarks.

**CPU model name** Intel(R) Core(TM) i7-12700K
**L1 data cache amount** 48 KiB (P core), 32 KiB (E core)
**L2 cache amount** 1.25 MiB
**System RAM amount** 64 GiB
**System RAM type & speed** DDR5 at 4800 MT/s
**Operating system** Linux
**Compiler** GCC 14.3.0

If you run the benchmarks on more than one system, please repeat it for each. Make sure that it is clear which system you are using whenever you report results.

On Linux, the CPU model name can be found by reading /proc/cpuinfo and looking for the model name
line. It should uniquely and unambiguously identify the CPU. Information on caches may require some slight research. In this case, I found the information Intel’s documentation (formerly Ark) and on Wikichip. 

In the labs, you can use inxi to find information about system RAM:
> module add inxi
> inxi -m
### 1.10 Benchmark: Lines I (5 marks)
Compare the performance of your line drawing (`draw_line_solid()`) under different conditions. For this task, use the line-benchmark application. It uses, in turn, Google’s microbenchmarking library, which
allows you to implement these benchmarks. Study the documentation and examples at the provided link. 

The provided code implements a simple example that shows how the library can be used. There are multiple variables that could affect line drawing performance with `draw_line_solid()).` Identify three (3) such variables. Make sure your choices are independent of each other. List your choices and for each briefly (one paragraph) explain why you believe that variable should affect performance. Include a hypothesis on how it affects performance (e.g., does changing the variable increase performance or decrease it?).

Next, test your hypotheses by varying each variable (independently). Make sure your tests use representative lines. You might need to test with multiple different lines for each value of a certain variable. Always benchmark different lines in isolation. Check your results: do they make sense?

**In your report:** 
- [x] As requested above, ==list== your variables, ==explanations== of them and your ==hypotheses==. 
- [x] ==Document== your representative lines and ==explain why== these are good picks (and ==sufficient== for your tests). 
- [ ] ==Present== the results from your benchmarks using a ==graph/plot== (do not just dump output of the benchmarking program in the terminal). 
- [ ] ==Evaluate and analyze== your results: Were your ==hypotheses correct==? ==Discuss== the results and try to ==explain== what you have seen.
- [ ] Do not forget to include units on axes/reported numbers. Marks are mainly awarded for a solid analysis and discussion of the results. Poor and/or badly motivated choices of variables will result in zero marks.
- [ ] Benchmarking incorrect line drawing may result in zero marks, as will nonsensical results.
### 1.11 Benchmark: Blitting (5 marks)
Compare the performance of your blit (blit_masked) to two more blit variants under different conditions. For this task, use the blit-benchmark program; like earlier tasks it uses Google’s microbenchmarking library.

You should first implement the additional blit variants in draw-ex.cpp:
- `blit_ex_solid`: A blit without alpha masking, where you just copy over the target image pixel by pixel.

Implement this yourself using loops in C++.
- `blit_ex_memcpy`: A blit without alpha masking, but implement this using std::memcpy, one for each line in the image.
These “extended” functions take a SurfaceEx argument instead of the Surface. The main difference is that `SurfaceEx` gives out a raw `std::uint8_t*` pointer to the image data; you will (minimally) need this for the `std::memcpy`-based variant. Study the declaration of `SurfaceEx` for details.

As always, you should ensure that the variants work correctly. There is no point in benchmarking incorrect code.
Benchmark the performance under different conditions. Identify candidate variables that could affect performance. Vary only one variable at a time. (However, the benchmark program should run all variants automatically.) Analyze your results. Do they seem realistic/reasonable?

**In your report:** 
- [ ] ==What== variables did you consider and ==why==? 
- [ ] Are there any ==others== that you did not consider, ==why not==?
- [ ] ==Present== your results using ==graphs/plots== (do not dump output from the terminal). What are your ==observations==? Try to ==explain== what you have seen.
	- [ ] Marks are mainly awarded for a solid analysis and discussion of the results. 
	- [ ] No marks are awarded for just showing the results. Do not forget to include units on axes/reported numbers.
### 1.12 Benchmark: Lines II (5 marks)
Study the *draw-ex.hpp* and *draw-ex.cpp* files, specifically the declaration of `draw_ex_line_solid()` and the provided `draw_ex_diagonal()`.

Your task is to implement a second line drawing method in `draw_ex_line_solid().` Choose from the following options:
- Research an optimized line drawing method. It should be based on existing (technical) literature that you can reference.
- If you previously implemented a method like DDA (with floating point), implement an integer-only method (e.g. Bresenham). If you already implemented an integer-only method, then implement a standard DDA with floats1.

Your improved method may use the `SurfaceEx` class. The method must function as a drop-in replacement for `draw_line_solid()` and work correctly in all circumstances.

Compare performance of the implementations. Include cases where you can use `draw_ex_diagonal` as a simple baseline for your comparisons. What can you learn from that?

Try to identify the ==bottlenecks== in your implementations. What could you do to ==improve performance== further? You might find ==Agner Fog’s instruction table listings== helpful, along with ==Matt Godbolt’s compiler explorer.==

**In your report:** 
- [ ] ==Present== your findings appropriately (see previous benchmarking tasks). 
- [ ] ==Analyze== the results and ==discuss== your conclusions.
- [ ] Do not forget to include units on axes/reported numbers. Marks are mainly awarded for a solid analysis and discussion of the results. 
- [ ] Your draw_ex_line_solid() must function correctly, i.e., as an one-to-one replacement of draw_line_solid().
