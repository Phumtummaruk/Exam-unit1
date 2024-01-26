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
int car = directionX + directionY
int directionX = 0;
int directionY = 0;


void Move()
{
    directionX += 1;
    directionY += 1;
}

void Turn()
{
    car = (car + 1) % 4;

}

bool Peek()
{
    int moveX = directionX;
    int moveY = directionY;
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
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    isAtGoal = IsCellGoal(directionX, directionY);
    return true; // just a placholder
}

#endregion