
//Number of students
int n = 91;

//Number of groups and moduo
double nDev30 = n / 30.0;
double nDev30Moduo = nDev30 % 1;

//CASE 1, number of students less then 30
if ((n / 30) < 1)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("Grupa 1, student: " + i);
    }
}

//CASE 2, number of students divisible by 30
if (n % 30 == 0)
{
    int numberOfGroups = n / 30;

    for (int i = 0; i < numberOfGroups; i++)
    {
        for (int j = 1; j <= 30; j++)
        {
            Console.WriteLine("Grupa " + (i + 1) + ", student: " + (j + i * 30));
        }
    }
}

//CASE 3, number of students between 30 and 60
if (nDev30 > 1.0 && nDev30 < 2.0)
{
    if ((n % 30) <= 25)
    {
        if (((n / 2) % 2) == 0)
        {
            for (int i = 1; i <= (n / 2); i++)
            {
                Console.WriteLine("Grupa 1, student: " + i);
            }

            for (int i = (n / 2) + 1; i <= n; i++)
            {
                Console.WriteLine("Grupa 2, student: " + i);
            }
        }
        else
        {
            for (int i = 1; i <= (int)(n / 2); i++)
            {
                Console.WriteLine("Grupa 1, student: " + i);
            }

            for (int i = (int)(n / 2) + 1; i < n + 1; i++)
            {
                Console.WriteLine("Grupa 2, student: " + i);
            }
        }
    }
    else
    {
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine("Grupa 1, student: " + i);
        }

        for (int i = 30; i <= n; i++)
        {
            Console.WriteLine("Grupa 2, student: " + i);
        }
    }
}

//CASE 4, number of students beyond to infinitely
if (nDev30 > 2.0 && nDev30Moduo != 0)
{
    double numberOfGroups = n / 30.0;
    int nGroups30 = (int)(numberOfGroups - 1);
    int lastIndex = 0;

    for (int i = 0; i < nGroups30; i++)
    {
        for (int j = 1; j <= 30; j++)
        {
            Console.WriteLine("Grupa " + (i + 1) + ", student: " + (j + i * 30));
            lastIndex = j + i * 30;
        }
    }

    int nRest = n - nGroups30 * 30;

    if ((nRest % 30) <= 25)
    {

        if (((nRest / 2) % 2) == 0)
        {
            for (int i = 1; i <= (nRest / 2); i++)
            {
                Console.WriteLine("Grupa " + (nGroups30 + 1) + ", student " + (i + nGroups30 * 30));
            }

            for (int i = (nRest / 2) + 1; i <= nRest; i++)
            {
                Console.WriteLine("Grupa " + (nGroups30 + 2) + ", student " + (i + nGroups30 * 30));
            }
        }
        else
        {
            for (int i = 1; i <= (int)(nRest / 2); i++)
            {
                Console.WriteLine("Grupa " + (nGroups30 + 1) + ", student " + (i + nGroups30 * 30));
            }

            for (int i = (int)(nRest / 2) + 1; i < nRest + 1; i++)
            {
                Console.WriteLine("Grupa " + (nGroups30 + 2) + ", student " + (i + nGroups30 * 30));
            }
        }
    }
    else
    {
        int nGroupPreLast = nGroups30 + 1;
        int nGroupLast = nGroups30 + 2;

        for (int i = lastIndex; i <= (lastIndex + 30); i++)
        {
            Console.WriteLine("Grupa " + nGroupPreLast + ", student " + i);
        }

        for (int i = (lastIndex + 30); i <= n; i++)
        {
            Console.WriteLine("Grupa " + nGroupLast + ", student " + i);
        }

    }
}