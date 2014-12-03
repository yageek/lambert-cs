using System;


namespace lambertcs
{	
	public enum Unit{Degree, Grad, Radian, Meter};

	public class Point
	{

		private const double degreeToradian = Math.PI/180.0;
		private const double radianTodegree = 180.0/Math.PI;

		private const double gradTodegree = 180.0/200.0;
		private const double degreeTograd = 200.0/180.0;

		private const double gradToradian = Math.PI/200.0;
		private const double radianTograd = 200.0/Math.PI;


		public Point (double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public double x { get; set;}
		public double y { get; set;}
		public double z { get; set;}

		public Unit unit { get{ return unit; } 
			set { 

				switch (value) {
				case Unit.Degree:
					ToDegree ();
					break;
				case Unit.Grad:
					ToGrad ();
					break;
				case Unit.Radian:
					ToRadian ();
					break;
				}
			} }

		public void translate(double x , double y, double z){

			this.x+= x;
			this.y+= y;
			this.z+= z;
		}
		private void Scale(double scale){
			this.x *= scale;
			this.y *= scale;
			this.z *= scale;
		}

		private void ToDegree(){
			switch (unit) {
			case Unit.Radian:
				Scale (radianTodegree);
				break;
			case Unit.Grad:
				Scale (gradTodegree);
				break;
			default:
				break;
			}
		}

		private void ToGrad(){
			switch(unit){
			case Unit.Degree:
				Scale (gradTodegree);
				break;
			case Unit.Radian:
				Scale (radianTograd);
				break;
			default:
				break;
			}
		}

		private void ToRadian(){
			switch (unit) {
			case Unit.Degree:
				Scale (degreeTograd);
				break;
			case Unit.Grad:
				Scale (gradToradian);
				break;
			default:
				break;
			}
		}
	}
}

