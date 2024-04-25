import 'package:test/test.dart';
import 'package:two_fer/two_fer.dart';

void main() {
  group('TwoFer', () {
    test('no name given', () {
      final result = twoFer();
      expect(result, equals('One for you, one for me.'));
    });

    test('a name given', () {
      final result = twoFer('Alice');
      expect(result, equals('One for Alice, one for me.'));
    });

    test('another name given', () {
      final result = twoFer('Bob');
      expect(result, equals('One for Bob, one for me.'));
    });

    test('explicit null instead of name', () {
      final result = twoFer(null);
      expect(result, equals('One for you, one for me.'));
    });
  });
}
