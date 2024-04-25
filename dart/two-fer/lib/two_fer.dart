String twoFer([String? name]) {
  final end = ", one for me.";

  return "${_getStart(name)}${end}";
}

String _getStart([String? name]) {
  var start = "One for you";

  if (name?.isNotEmpty ?? false) {
    start = "One for ${name}";
  }

  return start;
}
