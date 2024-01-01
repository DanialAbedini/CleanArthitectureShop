﻿using CleanArthitecture.Application.Services.Authentication;
using ErrorOr;
using MediatR;

namespace CleanArthitecture.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string? FirstName,
    string? LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;