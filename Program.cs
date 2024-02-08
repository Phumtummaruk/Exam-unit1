using System;
// Your program should start at this line.
/*
Example:
Move();
Move();
Move();
Turn();
Move();
Move();
Turn();
Turn();
Turn();
Move();
*/


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.
namespace Program
{
    int car = 0;
    CarDirection carDir = new CarDirection { X = 0, Y = 1 };
    struct Position
    {
        public int row;
        public int col;
    };

    Position carPosition = new Position();

    void Move()
    {
        carPosition.row += directionX;
        carPosition.col += directionY;
    }

    void Turn()
    {
        CarDirection++;
    }
    public struct CarDirection
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void RotateClockwise90Degrees()
        {
            int temp = X;
            X = Y;
            Y = -temp;
        }
    }
    bool Peek()
    {
        int moveX = carDir.X;
        int moveY = carDir.Y;

        switch (car)
        {
            case 0:
                moveY++;
                break;
            case 1:
                moveX++;
                break;
            case 2:
                moveY--;
                break;
            case 3:
                moveX--;
                break;
        }

        bool obstacleInFront = IsCellObstacle(carPos.row + moveX, carPos.col + moveY);
        return obstacleInFront;
    }
    bool AtGoal()
    {
        bool isAtGoal = IsCellGoal(carPosition.row, carPosition.col);
        return isAtGoal;
    }

    void MoveForward(int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (!Peek())
                Move();
            else
                break;
        }
    }

    void Turn180Deg()
    {
        Turn();
        Turn();
    }

    void Turn270Deg()
    {
        Turn();
        Turn();
        Turn();
    }
    bool IsCellObstacle(int row, int col)
    {
        // ใส่โค้ดเช็คอุปสรรคที่ช่องที่ต้องการจะขยับไป
        // คืนค่า true ถ้ามีอุปสรรค และ false ถ้าไม่มี
        return false; // เริ่มต้นโดยกำหนดให้ไม่มีอุปสรรค
    }

    bool IsCellGoal(int row, int col)
    {
        // ใส่โค้ดเช็คว่าช่องที่ต้องการจะไปนั้นเป็นเส้นชัยหรือไม่
        // คืนค่า true ถ้าเป็นเส้นชัย และ false ถ้าไม่ใช่
        return false; // เริ่มต้นโดยกำหนดให้ไม่ใช่เส้นชัย
    }
}
#endregion