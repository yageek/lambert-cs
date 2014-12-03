#Description
A simple C# library to convert Lambert Coordinates to GPS WGS84 coordinates based on the [IGN alorithms and methods](http://geodesie.ign.fr/contenu/fichiers/documentation/algorithmes/notice/NTG_71.pdf)

# NuGet

`PM> Install-Package LambertCS`
# Usage

```cs
	Point pt = Lambert.convertToWGS84Deg(668832.5384, 6950138.7285, Zone.Lambert93);
 	Console.WriteLine("Point latitude:{0} longitude:{1}", pt.y, pt.x);
```
