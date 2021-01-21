using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_8
{
    class Program
    {
        static void Main()
        {
            var instructions = Inputs.BigInput
                .Split("\r\n")
                .Select(x => new Instruction(x))
                .ToArray();

            var numberOfInstructions = instructions.Count();

            foreach (var inst in instructions.Where(x => x.InstructionType != InstructionType.Accumulator))
            {
                var currentIndex = 0;
                var currentAccumulator = 0;
                var visitedInstructions = new List<Instruction>();
                var loopDetected = false;

                if (inst.InstructionType == InstructionType.Jump)
                {
                    inst.InstructionType = InstructionType.NoOperation;
                }
                else if (inst.InstructionType == InstructionType.NoOperation)
                {
                    inst.InstructionType = InstructionType.Jump;
                }

                while (numberOfInstructions > currentIndex)
                {
                    var currentInstruction = instructions[currentIndex];
                    if (visitedInstructions.Contains(currentInstruction))
                    {
                        Console.WriteLine("Loop detected");

                        if (inst.InstructionType == InstructionType.Jump)
                        {
                            inst.InstructionType = InstructionType.NoOperation;
                        }
                        else if (inst.InstructionType == InstructionType.NoOperation)
                        {
                            inst.InstructionType = InstructionType.Jump;
                        }

                        loopDetected = true;
                        break;
                    }

                    visitedInstructions.Add(currentInstruction);

                    if (currentInstruction.InstructionType == InstructionType.NoOperation)
                    {
                        currentIndex++;
                    }
                    else if (currentInstruction.InstructionType == InstructionType.Jump)
                    {
                        currentIndex += currentInstruction.Value;
                    }
                    else if (currentInstruction.InstructionType == InstructionType.Accumulator)
                    {
                        currentAccumulator += currentInstruction.Value;
                        currentIndex++;
                    }
                    else
                    {
                        // Not expected to get into this situation.
                        throw new Exception("oh no");
                    }
                }

                if (!loopDetected)
                {
                    Console.WriteLine("Program terminated");
                    Console.WriteLine(currentAccumulator);
                    break;
                }
            }
        }
    }
}
