#include <iostream>
#include <vector>

using namespace std;

class Student
{
	string name;
	string birthday;
	string group;
	vector<int> marks;

	Student(string nameP, string birthdayP, string groupP) : name(nameP), birthday(birthdayP), group(groupP) {};
	
	void setname(string nameP) { name = nameP; }
	void setbirthday(string birthdayP) { birthday = birthdayP; }
	void setgroup(string groupP) { group = groupP; }

	void setmark(int mark)
	{
		marks.push_back(mark);
		for (int mark : marks) { cout << mark; }
	}
	void setmarks(vector<int> newmarks) { marks = newmarks; }

	string getname() { return name; }
	string getbirthday() { return birthday; }
	string getgroup() { return group; }

	int getmark(int mark){ marks.back();}
	vector<int> getmarks() { return marks; }
};

int main()
{
   
}
