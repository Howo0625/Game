#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	int restart = 0;
	while (restart == 0)
	{
		srand(time(NULL));

		/* 指定亂數範圍 */
		int min = 1, max = 999, Ans = 0, playeridx = 1;
		int player;
		int reply;

		Ans = rand() % (max - min + 1) + min;

		printf("How many player do you want to play : ");
		scanf_s("%d", &player);

		printf("The range is between 1 ~ 9999\n");

		while (1)
		{
			printf("Player%d enter your answer : ", playeridx);
			scanf_s("%d", &reply);

			if (reply == Ans)
			{
				printf("player%d is loser\n", playeridx);
				break;
			}
			else if (reply > Ans)
			{
				if (reply < max)
				{
					printf("The range is between %d ~ %d\n", min, reply);
					max = reply;
				}
				else
				{
					printf("The range is between %d ~ %d\n", min, max);
				}

				playeridx++;
				if (playeridx > player) playeridx = 1;
			}
			else
			{
				if (reply > min)
				{
					printf("The range is between %d ~ %d\n", reply, max);
					min = reply;
				}
				else
				{
					printf("The range is between %d ~ %d\n", min, max);
				}

				playeridx++;
				if (playeridx > player) playeridx = 1;
			}
		}

		printf("\n");
		printf("Restart please press : 0\tLeave please press : 1\n");
		scanf_s("%d", &restart);
	}
}
