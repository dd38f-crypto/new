*,
*::after,
*::before {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}

:root {
  --dark-color: #000;
}

body {
  display: flex;
  align-items: flex-end;
  justify-content: center;
  min-height: 100vh;
  background-color: var(--dark-color);
  overflow: hidden;
  perspective: 1000px;
}

.night {
  position: fixed;
  left: 50%;
  top: 0;
  transform: translateX(-50%);
  width: 100%;
  height: 100%;
  filter: blur(0.1vmin);
  background-image: radial-gradient(
      ellipse at top,
      transparent 0%,
      var(--dark-color)
    ),
    radial-gradient(
      ellipse at bottom,
      var(--dark-color),
      rgba(145, 233, 255, 0.2)
    ),
    repeating-linear-gradient(
      220deg,
      rgb(0, 0, 0) 0px,
      rgb(0, 0, 0) 19px,
      transparent 19px,
      transparent 22px
    ),
    repeating-linear-gradient(
      189deg,
      rgb(0, 0, 0) 0px,
      rgb(0, 0, 0) 19px,
      transparent 19px,
      transparent 22px
    ),
    repeating-linear-gradient(
      148deg,
      rgb(0, 0, 0) 0px,
      rgb(0, 0, 0) 19px,
      transparent 19px,
      transparent 22px
    ),
    linear-gradient(90deg, rgb(0, 255, 250), rgb(240, 240, 240));
}

.flowers {
  position: relative;
  transform: scale(0.9);
}

.flower {
  position: absolute;
  bottom: 10vmin;
  transform-origin: bottom center;
  z-index: 10;

  --fl-speed: 0.8s;

  &--1 {
    animation: moving-flower-1 4s linear infinite;
    .flower__line {
      $delay: 0.3s;

      height: 70vmin;
      animation-delay: $delay;

      &__leaf {
        &--1 {
          animation: blooming-leaf-right var(--fl-speed) 1.6s backwards;
        }

        &--2 {
          animation: blooming-leaf-right var(--fl-speed) 1.4s backwards;
        }

        &--3 {
          animation: blooming-leaf-left var(--fl-speed) 1.2s backwards;
        }

        &--4 {
          animation: blooming-leaf-left var(--fl-speed) 1s backwards;
        }

        &--5 {
          animation: blooming-leaf-right var(--fl-speed) 1.8s backwards;
        }

        &--6 {
          animation: blooming-leaf-left var(--fl-speed) 2s backwards;
        }
      }
    }
  }

  &--2 {
    left: 50%;
    transform: rotate(20deg);
    animation: moving-flower-2 4s linear infinite;
    .flower__line {
      height: 60vmin;
      animation-delay: 0.6s;

      &__leaf {
        &--1 {
          animation: blooming-leaf-right var(--fl-speed) 1.9s backwards;
        }

        &--2 {
          animation: blooming-leaf-right var(--fl-speed) 1.7s backwards;
        }

        &--3 {
          animation: blooming-leaf-left var(--fl-speed) 1.5s backwards;
        }

        &--4 {
          animation: blooming-leaf-left var(--fl-speed) 1.3s backwards;
        }
      }
    }
  }

  &--3 {
    left: 50%;
    transform: rotate(-15deg);
    animation: moving-flower-3 4s linear infinite;
    .flower__line {
      animation-delay: 0.9s;
      &__leaf {
        &--1 {
          animation: blooming-leaf-right var(--fl-speed) 2.5s backwards;
        }

        &--2 {
          animation: blooming-leaf-right var(--fl-speed) 2.3s backwards;
        }

        &--3 {
          animation: blooming-leaf-left var(--fl-speed) 2.1s backwards;
        }

        &--4 {
          animation: blooming-leaf-left var(--fl-speed) 1.9s backwards;
        }
      }
    }
  }

  &__leafs {
    position: relative;
    animation: blooming-flower 2s backwards;

    $delay: 0.8;
    $inc: 0.3;

    @for $i from 1 through 3 {
      &--#{$i} {
        $delay: $delay + $inc;
        animation-delay: #{$delay}s;
      }
    }

    &::after {
      content: "";
      position: absolute;
      left: 0;
      top: 0;
      transform: translate(-50%, -100%);
      width: 8vmin;
      height: 8vmin;
      background-color: #6bf0ff;
      filter: blur(10vmin);
    }
  }

  &__leaf {
    position: absolute;
    bottom: 0;
    left: 50%;
    width: 8vmin;
    height: 11vmin;
    border-radius: 51% 49% 47% 53% / 44% 45% 55% 69%;
    background-color: #a7ffee;
    /* Cập nhật màu sắc sang màu hồng để đồng bộ */
    background-image: linear-gradient(to top, #ff78dd, #faace6);
    transform-origin: bottom center;
    opacity: 0.9;
    box-shadow: inset 0 0 2vmin rgba(255, 255, 255, 0.5);

    &--1 {
      transform: translate(-10%, 1%) rotateY(40deg) rotateX(-50deg);
    }

    &--2 {
      transform: translate(-50%, -4%) rotateX(40deg);
    }

    &--3 {
      transform: translate(-90%, 0%) rotateY(45deg) rotateX(50deg);
    }

    &--4 {
      width: 8vmin;
      height: 8vmin;
      transform-origin: bottom left;
      border-radius: 4vmin 10vmin 4vmin 4vmin;
      /* Chuẩn hóa -0% thành 0% */
      transform: translate(0%, 18%) rotateX(70deg) rotate(-43deg);
      /* Cập nhật màu sắc sang màu hồng để đồng bộ */
      background-image: linear-gradient(to top, #ff78dd, #faace6);
      z-index: 1;
      opacity: 0.8;
    }
  }

/* ... (Phần giữa của file SCSS giữ nguyên như file gốc cho đến selector &__g-fr) ... */

  &__g-fr {
    position: absolute;
    bottom: -4vmin;
    /* Sửa lỗi cú pháp: left: vmin; thành left: 0; */
    left: 0;
    transform-origin: bottom left;
    z-index: 10;

    animation: flower__g-fr-ans 2s linear infinite;

/* ... (Phần còn lại của file SCSS giữ nguyên như file gốc) ... */
