namespace solv_the_assignment_OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Part 01
            /*
            Question 1: 
            What is the primary purpose of an interface in C#? 
            b) To define a blueprint for a class

            Question 2:
            Which of the following is NOT a valid access modifier for interface members in C#? 
            a) private

            Question 3:
            Can an interface contain fields in C#?
            b) No 
            (interfaces cannot contain fields)

            Question 4:
            In C#, can an interface inherit from another interface?
            b) Yes, interfaces can inherit from multiple interfaces

            Question 5:
            Which keyword is used to implement an interface in a class in C#?
            d) implements 

            Question 6:
            Can an interface contain static methods in C#? 
            a) Yes 

            Question 7:
            In C#, can an interface have explicit access modifiers for its members?
            b) No, all members are implicitly public 

            Question 8:
            What is the purpose of an explicit interface implementation in C#? 
            a) To hide the interface members from outside access 

            Question 9:
            In C#, can an interface have a constructor? 
            b) No, interfaces cannot have constructors 

            Question 10:
            How can a C# class implement multiple interfaces?
            c) By separating interface names with commas 
            */
            #endregion

            #region Part 02
            /*
            Question 01: 
       
            Define an interface named IShape with a property Area and a method 
            DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from 
            IShape. Implement these interfaces in classes Circle and Rectangle. Test your 
            implementation by creating instances of both classes and displaying their shape 
            information.
            */
            ICircle circle = new Circle(2); 
            circle.DisplayShapeInfo();
            Console.WriteLine();
            IRectangle rectangle = new Rectangle(3, 4);
            rectangle.DisplayShapeInfo();

            #endregion
        }
    }
}
