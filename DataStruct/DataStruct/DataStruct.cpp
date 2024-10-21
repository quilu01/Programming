// DataStruct.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>
#include <string>

using namespace std;

const int PeopleCount = 4; 


struct Person {
    string firstName;
    string lastName;
    int age;
};

 
Person** CreatePeopleArray() {
    Person** people = new Person * [PeopleCount];

    people[0] = new Person{ "Casey", "Aguilar", 30 };
    people[1] = new Person{ "Brock", "Curtis", 19 };
    people[2] = new Person{ "Blake", "Diaz", 21 };
    people[3] = new Person{ "Cristian", "Evans", 55 };

    return people;
}

 
void WritePerson(Person* person) {
    cout << "First Name: " << person->firstName
        << "; Last Name: " << person->lastName
        << "; Age: " << person->age
        << endl;
}


void ClearPeople(Person** people, int count) {
    for (int i = 0; i < count; i++) {
        delete people[i];
    }
    delete[] people;
}

 
void Task1_FindPersonByLastName() {
    
    Person** people = CreatePeopleArray();

     
    for (int i = 0; i < PeopleCount; i++) {
        WritePerson(people[i]);
    }

    
    string lastName;
    cout << "Enter last name: ";
    cin >> lastName;

    
    int foundIndex = -1; 

    for (int i = 0; i < PeopleCount; i++) {
        if (people[i]->lastName == lastName) {
            foundIndex = i;
            break;  
        }
    }

    
    if (foundIndex == -1) {
        cout << "Could not find a person by last name: " << lastName << endl;
    }
    else {
        cout << "A person's last name " << endl;
    }

void Breakpoints1() {
    double add = 1.0;
    double sum = 1.0;
    for (int i = 0; i < 10; i++) {
        sum += add * i;
        add *= 1.1;
        cout << "Total sum is " << sum << endl;
    }
    
}

void Breakpoints2() {
    double add = 1.0;
    double sum = 0.0;
    for (int i = 0; i < 1000; i++)
    {
        sum += add * i;
        if (i % 3 == 0)
        {
            add *= 1.1;
        }
        else
        {
            add /= 3.0;
        }
    }
    cout << "Total sum is " << sum << endl;
}

void IntegralArrays() {
    int* array = new int[10];
    int temp;
    for (int i = 0; i < 10; i++) {
        cin >> array[i];
    }
    for (int i = 0; i < 9; i++)
    {
        for (int j = i; j < 10; j++)
        {
            if (array[i] > array[j])
            {
                temp = i;
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    for (int i = 0; i < 10; i++)
    {
        cout << array[i] << endl;
    }
    delete[] array;
}

void DoubleArrays()
{
    double searchingValue;
    double* array = new double[12];
    int sum = 0;
    for (int i = 0; i < 12; i++)
    {
        cin >> array[i];
    }
    cout << "Enter seach value: ";
    cin >> searchingValue;
    cout << endl;
    for (int i = 0; i < 12; i++)
    {
        if (array[i] >= searchingValue)
        {
            sum++;
        }
    }
    cout << sum << endl;
    delete[] array;
}
void CharactersArray()
{
    char* array = new char[8];
    string chars = "abcdefghijklmnopqrstuvwxyz";
    for (int i = 0; i < 8; i++)
    {
        cin >> array[i];
    }
    for (int i = 0; i < 8; i++)
    {
        if (chars.find(array[i] < chars.length()))
        {
            cout << array[i] << endl;
        }
    }
    delete[] array;
}

double GetPower(double base, int exponent)
{
    return pow(base, exponent);
}

void DemoGetPower()
{
    double base;
    int exponent;
    cin >> base;
    cin >> exponent;
    cout << base << " ^ " << exponent << " = " << GetPower(base, exponent) << endl;
}

void Address1()
{
    int a = 5;
    int b = 4;
    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;
    
    double c = 13.5;
    cout << "Address of c: " << &c << endl;
    
    bool d = true;
    cout << "Address of d: " << &d << endl;
}

void Address2()
{
    int a[10] = { 1, 2, 7, -1, 5, 3, -1, 7, 1, 6 };
    cout << "Size of int type: " << sizeof(int) << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of a[" << i << "]: " << &a[i] << endl;
    }
    
    cout << endl;
    cout << "Size of double type: " << sizeof(double) << endl;
    double b[10] = { 1.0, 2.0, 7.0, -1.0, 5.0, 3.5, -1.8, 7.2, 1.9, 6.2 };
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of b[" << i << "]: " << &b[i] << endl;
    }
}

void Address3()
{
    int a = 5;
    int& b = a;
    
    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;
    cout << endl;
    b = 7;
    cout << "Value of a: " << a << endl;
}
void Foo1(double a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;

    cout << "New value of a in Foo(): " << a << endl;
}
void Foo2(double& a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;

    cout << "New value of a in Foo(): " << a << endl;
}
void Address4()
{
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    Foo1d(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}
void Address5()
{
    double a = 5.0;

    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    Foo2(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}
void Address6()
{
    int a = 5;
    int* pointer = &a;
    
    cout << "Address of a: " << &a << endl;
    cout << "Address in pointer: " << pointer << endl;
    cout << "Address of pointer: " << &pointer << endl;
   
    cout << endl;
    *pointer = 7;
    cout << "Value in a: " << a << endl;
    cout << "Value by pointer address: " << *pointer << endl;
}

void Foo3()
{
    cout << "Address in pointer: " << a << endl;
    cout << "Address of pointer: " << &a << endl;
    cout << "Value in pointer address: " << *a << endl;
    *a = 15.0;
    cout << "New value in pointer address: " << *a << endl;
}
void Address7()
{
    double value = 5.0;
    double* pointer = &value;
    cout << "Address of value in main(): " << &value << endl;
    cout << "Address in pointer in main(): " << pointer << endl;
    cout << "Address of pointer in main(): " << &pointer << endl;
    cout << "Value of a in main(): " << value << endl;
    cout << endl;
    
    Foo3(pointer);
    
    cout << endl;
    cout << "Value of a in main(): " << value << endl;
}
int main()
{
    
}


