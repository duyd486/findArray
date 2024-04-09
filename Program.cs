class Program {
    public static void Main(string[] args)
    {
        string[] myStudents = { "Mai", "An", "Hao", "Hoang", "Tam", "Duy"};
        Console.WriteLine("Nhap ten can tim: ");
        string name = Console.ReadLine();

        bool hasStudent = false;
        for (int i = 0; i < myStudents.Length; i++) {
            if (myStudents[i].Equals(name)) {
                hasStudent = true;
                Console.WriteLine("Sinh vien co mat");
                break;
            }
        }
        if (!hasStudent) {
            Console.WriteLine("Khong co sinh vien");
        }
    }
}