namespace testbaithi.Utilities
{
    public class StringProcessPDP516
    {
        // Phương thức chuyển chuỗi sang chữ in hoa
        public string LowerToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return input.ToUpper();
        }
    }
}
