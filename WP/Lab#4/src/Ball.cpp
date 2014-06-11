#include "../Ball.h"

Ball::Ball()
{
    radius = rand() % RADIUS_LIMIT_MAX + RADIUS_LIMIT_MIN;
    x_old_pos = (LIMIT_LEFT + LIMIT_RIGHT) / 2;
    y_old_pos = (LIMIT_TOP + LIMIT_BOTTOM) / 2;

    velocity = rand() % VELOCITY_LIMIT_MAX + VELOCITY_LIMIT_MIN;

    angle = rand() % 360;

}
Ball::Ball(int timer)
{
    radius = rand() % RADIUS_LIMIT_MAX + RADIUS_LIMIT_MIN;
    x_old_pos = (LIMIT_LEFT + LIMIT_RIGHT) / 2;
    y_old_pos = (LIMIT_TOP + LIMIT_BOTTOM) / 2;

    velocity = rand() % VELOCITY_LIMIT_MAX + VELOCITY_LIMIT_MIN;

    angle = rand() % 360;

    randColor();

    TIMER = timer;


}

void Ball::randColor()
{
    color[0] = rand()%255;
    color[1] = rand()%255;
    color[2] = rand()%255;

}

void Ball::newPos()
{
    x_new_pos = x_old_pos + cos(toRadian(angle)) * velocity;
    y_new_pos = y_old_pos + sin(toRadian(angle)) * velocity;

}
double Ball::toRadian(int degrees)
{
    return (double)degrees * M_PI/180;

}

void Ball::reshapeBoundaries()
{

    while(1)
    {
        int boundaryPos = 1;
        /// Check from left
        boundaryPos = x_new_pos - radius;
        if (boundaryPos < LIMIT_LEFT) {
            int delta_x = abs(LIMIT_LEFT - boundaryPos);
            int delta_y = abs(delta_x * tan(toRadian(angle)));
            x_new_pos += delta_x;


            if (angle <= 180 && angle >= 90){
                y_new_pos += delta_y;
                angle = 180 - angle;
            }


            if (angle <= 270 && angle > 180) {
                y_new_pos -= delta_y;
                angle = 360 - (angle - 180);
            }
            randColor();
            continue;
        }

        /// Check from top
        boundaryPos = y_new_pos - radius;
        if (boundaryPos < LIMIT_TOP) {
            int delta_y = abs(LIMIT_TOP - boundaryPos);
            int delta_x = abs(delta_y / tan(toRadian(angle)));
            y_new_pos += delta_y;

            if (angle <= 90 && angle >= 0) {
                x_new_pos -= delta_x;
                angle = 360 - angle;
            }

            if (angle < 180 && angle > 90) {
                x_new_pos += delta_x;
                angle = 180 + (180 - angle);
            }
            randColor();
            continue;
        }

        /// Check from right
        boundaryPos = x_new_pos + radius;
        if (boundaryPos > LIMIT_RIGHT) {
            int delta_x = abs(boundaryPos - LIMIT_RIGHT);
            int delta_y = abs(delta_x * tan(toRadian(angle)));
            x_new_pos -= delta_x;

            if (angle <= 90 && angle >= 0) {
                y_new_pos += delta_y;
                angle = 180 - angle;
            }

            if (angle <= 360 && angle >= 270) {
                y_new_pos -= delta_y;
                angle = (360 - angle) + 180;
            }

            randColor();
            continue;
        }

        /// Check from bottom
        boundaryPos = y_new_pos + radius;
        if (boundaryPos > LIMIT_BOTTOM) {
            int delta_y = abs(boundaryPos - LIMIT_BOTTOM);
            int delta_x = abs(delta_y / tan(toRadian(angle)));
            y_new_pos -= delta_y;

            if (angle <= 270 && angle >= 180) {
                x_new_pos += delta_x;
                angle = 90 + 270 - angle;
            }

            if (angle <= 360 && angle >= 270) {
                x_new_pos -= delta_x;
                angle = 360 - angle;
            }
            randColor();
            continue;
        }
        break;
    }


}

void Ball::drawGhost(HDC hdc)
{
    int tempRad = radius - 1;
    int oldLeft = x_old_pos - tempRad;
    int oldRight = x_old_pos + tempRad;
    int oldBottom = y_old_pos + tempRad;
    int oldTop = y_old_pos - tempRad;

    HPEN hPen = CreatePen(PS_SOLID,1,RGB(255,255,255));
    HBRUSH hBrush = CreateSolidBrush(RGB(255,255,255));

    SelectObject(hdc,hPen);
    SelectObject(hdc,hBrush);

    Ellipse(hdc,oldLeft,oldTop,oldRight,oldBottom);
    DeleteObject(hPen);
    DeleteObject(hBrush);

}

void Ball::drawBall(HDC hdc)
{
    int tempRad = radius - 1;
    int newLeft = x_new_pos - tempRad;
    int newRight = x_new_pos + tempRad;
    int newBottom = y_new_pos + tempRad;
    int newTop = y_new_pos - tempRad;

    HBRUSH hBrush = CreateSolidBrush(RGB(color[0], color[1], color[2]));
    HPEN hPen = CreatePen(PS_SOLID, 1, RGB(0, 0, 0));

    SelectObject(hdc,hPen);
    SelectObject(hdc,hBrush);

    Ellipse(hdc,newLeft, newTop, newRight, newBottom);
    DeleteObject(hPen);
    DeleteObject(hBrush);

    x_old_pos = x_new_pos;
    y_old_pos = y_new_pos;
    _livingTime += TIMER;

}
int Ball::ballsAngle(int xPos, int yPos)
{
    int x = xPos - x_new_pos;
    int y = yPos - y_new_pos;

    int value = 0;
    if (x >= 0 && y >= 0) {
        x = abs(x);
        y = abs(y);

        if (x == 0)
            return 90;

        value = 180 * atan(y/x) / M_PI;
    }
    if (x <= 0 && y >= 0) {
        x = abs(x);
        y = abs(y);
        if (y == 0)
            return 180;

        value = (180 * atan(x/y) / M_PI) + 90;
    }
    if (x <= 0 && y <= 0) {
        x = abs(x);
        y = abs(y);
        if (x == 0)
            return 270;

        value = (180 * atan(y/x) / M_PI) + 180;
    }
    if (x >= 0 && y <= 0) {
        x = abs(x);
        y = abs(y);
        if (y == 0)

        value = (180 * atan(x/y)  / M_PI) + 270;
    }

    return value;

}

bool Ball::interactBall(Ball &ball)
{
    int distance = sqrt(pow((x_new_pos - ball.x_new_pos), 2) + pow((y_new_pos - ball.y_new_pos), 2));
    if (distance < (radius + ball.radius)) {
        int delta = (radius + ball.radius) - distance;
        int delta_x = abs(cos(toRadian(angle)) * delta);
        int delta_y = abs(sin(toRadian(angle)) * delta);

        if (angle >= 0 && angle <= 90) {
            x_new_pos -= delta_x;
            y_new_pos += delta_y;
        }
        if (angle > 90 && angle <= 180) {
            x_new_pos += delta_x;
            y_new_pos += delta_y;
        }
        if (angle > 180 && angle <= 270) {
            x_new_pos += delta_x;
            y_new_pos -= delta_y;
        }
        if (angle > 270 && angle <= 360) {
            x_new_pos -= delta_x;
            y_new_pos -= delta_y;
        }

        angle = rand() % 360;
        ball.angle = rand() % 360;
        return true;
    }

    if (distance == (radius + ball.radius)) {
        if (angle >= 0 && angle <= 180)
            angle += 180;
        else
            angle -= 180;

        angle = rand() % 360;
        ball.angle = rand() % 360;
        return true;
    }

    return false;
}
