import unittest
from divisibility import divisible_by_3_or_5


class TestDivisibleBy3Or5(unittest.TestCase):

    def test_divisible_by_3(self):
        result = divisible_by_3_or_5(9)
        print("test_divisible_by_3 ->", result)
        self.assertTrue(result)

    def test_divisible_by_5(self):
        result = divisible_by_3_or_5(10)
        print("test_divisible_by_5 ->", result)
        self.assertTrue(result)

    def test_divisible_by_both(self):
        result = divisible_by_3_or_5(15)
        print("test_divisible_by_both ->", result)
        self.assertTrue(result)

    def test_not_divisible(self):
        result = divisible_by_3_or_5(7)
        print("test_not_divisible ->", result)
        self.assertFalse(result)

    def test_zero(self):
        result = divisible_by_3_or_5(0)
        print("test_zero ->", result)
        self.assertTrue(result)


if __name__ == "__main__":
    unittest.main(verbosity=2)
