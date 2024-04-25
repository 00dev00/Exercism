import 'package:scrabble_score/scrabble_score.dart';
import 'package:test/test.dart';

void main() {
  group('ScrabbleScore', () {
    test('lowercase letter', () {
      final result = score('a');
      expect(result, equals(1));
    });

    test('uppercase letter', () {
      final result = score('A');
      expect(result, equals(1));
    });

    test('valuable letter', () {
      final result = score('f');
      expect(result, equals(4));
    });

    test('short word', () {
      final result = score('at');
      expect(result, equals(2));
    });

    test('short, valuable word', () {
      final result = score('zoo');
      expect(result, equals(12));
    });

    test('medium word', () {
      final result = score('street');
      expect(result, equals(6));
    });

    test('medium, valuable word', () {
      final result = score('quirky');
      expect(result, equals(22));
    });

    test('long, mixed-case word', () {
      final result = score('OxyphenButazone');
      expect(result, equals(41));
    });

    test('english-like word', () {
      final result = score('pinata');
      expect(result, equals(8));
    });

    test('empty input', () {
      final result = score('');
      expect(result, equals(0));
    });

    test('entire alphabet available', () {
      final result = score('abcdefghijklmnopqrstuvwxyz');
      expect(result, equals(87));
    });
  });
}
