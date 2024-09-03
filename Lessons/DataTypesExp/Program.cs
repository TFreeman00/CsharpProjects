
/*
When choosing a data type, consider how it will be used elsewhere. For example, if you're storing data in a database, you'll need to map your C# data type to the database's data type. If you're sending data to a web service, you'll need to ensure that the data can be serialized and deserialized correctly.

If you're not sure which data type to use, stick with the basics. The following are good defaults:

* int for whole numbers that aren't too large
* decimal for numbers that represent money
* bool for true or false values
* string for alphanumeric values

However, there are some specialized data types that can be useful in certain situations. For example:

* byte is useful when working with encoded data that comes from other computer systems or using different character sets. This is common when working with binary data, like images or audio files.
* double is useful when working with geometric or scientific purposes. For example, when building a game that involves motion, you might use double to represent the position and velocity of objects.
* System.DateTime is useful when you need to represent a specific date and time. This is common when storing data in a database or sending data to a web service.
* System.TimeSpan is useful when you need to represent a span of years / months / days / hours / minutes / seconds / milliseconds. This is common when calculating the difference between two dates or times.
*/
