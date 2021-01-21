namespace Day_8
{
    public class Instruction
    {
        public Instruction(string input)
        {
            var instructionTypeString = input.Substring(0, 3);

            switch (instructionTypeString)
            {
                case "nop":
                    InstructionType = InstructionType.NoOperation;
                    break;
                case "acc":
                    InstructionType = InstructionType.Accumulator;
                    break;
                case "jmp":
                    InstructionType = InstructionType.Jump;
                    break;
            }

            var valueString = input.Substring(5);
            var sign = input[4] == '-' ? -1 : 1;
            Value = sign * int.Parse(valueString);
        }

        public InstructionType InstructionType { get; set; }
        public int Value { get; set; }
    }
}
