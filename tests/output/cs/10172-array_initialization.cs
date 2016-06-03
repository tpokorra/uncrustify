int[] = new int[] {1,2,3};

void foo()
{
	int[] = new int[] {1,2,3};

	funcwithverylongname(new int[] {1,2,3});

	funcwithverylongname(new int[]
		{1,2,3});

	funcwithverylongname(new int[]
		{
			1,2,3
		}
	                     );

	funcwithverylongname(new int[] {
			1,2,3
		});

	funcwithverylongname(new int[]
	                     {
	                         1,2,3
	                     },
	                     anotherparam
	                     );

	funcwithverylongname(new int[] {
	                         1,2,3
	                     },
	                     anotherparam
	                     );

}
