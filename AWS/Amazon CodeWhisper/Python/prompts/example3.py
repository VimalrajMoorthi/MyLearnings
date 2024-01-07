""" 
Function that takes a list that contains some numbers and strings, format them 
into a string in which the numbers a prepended with a '#' and the strings 
are wrapped in double quotes
"""

def format_list(list_of_things):
    formatted_string = ''
    for thing in list_of_things:
        if type(thing) is int:
            formatted_string += f'# {thing}\n'
        else:
            formatted_string += f'"{thing}"\n'
    return formatted_string