import lib1
import unittest

class TestFibonacci(unittest.TestCase):
    def test_1(self):
        self.assertEqual(lib1.fibonacci(0), 0)
    def test_2(self):
        self.assertEqual(lib1.fibonacci(1), 1)
    def test_3(self):
        self.assertEqual(lib1.fibonacci(2), 1)
    def test_4(self):
        self.assertEqual(lib1.fibonacci(3), 2)
    def test_5(self):
        self.assertEqual(lib1.fibonacci(4), 3)

if __name__ == "__main__":
    unittest.main()