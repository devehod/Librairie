// DateOnly constructor parameters: 
// new(year, month, day-of-month)
//DateOnly holiday1 = new(2026, 12, 25); // Christmas Day
DateOnly[] holidayDates = [
	new(2026, 12, 25), // Christmas Day
	new(2026, 12, 26), // Boxing Day 
	new(2027, 1, 1),   // New Year's Day
	new(2027, 3, 26),  // Good Friday
	new(2027, 3, 29),  // Easter Monday
	new(2027, 5, 3),   // Early May bank holiday
	new(2027, 5, 31),  // Spring bank holiday
	new(2027, 8, 30),  // Summer bank holiday
	new(2027, 09, 15), // Tabaski 2027
	new(2027, 12, 26), // Boxing Day 
    new(2027, 12, 26) // Boxing Day 
];
Console.WriteLine("Holidays when the library is closed:");
foreach (DateOnly date in holidayDates) {
	Console.WriteLine(date.ToLongDateString());
}
