def password_validate(password):
    min_length = 8
    has_upper = False
    has_lower = False
    has_digit = False
    has_symbols = False
    symbols = "!@#$%^&*()-_=+[{]}\|;:',<.>/?"

    if len(password) < min_length:
        print('Senha muito curta.')
        return False

    for char in password:
        if char.isupper():
            has_upper = True
        elif char.islower():
            has_lower = True
        elif char.isdigit():
            has_digit = True
        elif char in symbols:
            has_symbols = True
        
    if not has_upper:
        print('Senha precisa de uma letra maiúscula')
        return False
    if not has_lower:
        print('Senha precisa de um minúsculo')
        return False
    if not has_digit:
        print('Senha precisa de um número')
        return False
    if not has_symbols:
        print('Senha precisa conter um caracter especial (símbolo)')
        return False

    print('Senha forte')
    return True

password_validate('EduardoScheffer10#2022')